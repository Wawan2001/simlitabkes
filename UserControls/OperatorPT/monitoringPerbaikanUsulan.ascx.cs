using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;
using simlitekkes.UIControllers;
using System.Data;
using System.IO;
using simlitekkes.Models.Sistem;

namespace simlitekkes.UserControls.OperatorPT
{
    public partial class monitoringPerbaikanUsulan : System.Web.UI.UserControl
    {
        Models.login objLogin;
        Core.manipulasiData objManipData = new Core.manipulasiData();
        uiDropdownList obj_uiDropdownlist = new uiDropdownList();
        uiNotify noty = new uiNotify();
        uiGridView obj_uiGridView = new uiGridView();
        uiModal objModal = new uiModal();
        Models.PT.monitoringPerbaikanUsulan modelPerbaikanUsulan = new Models.PT.monitoringPerbaikanUsulan();
        string KD_JENIS_KEGIATAN = "1";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["objLogin"] == null)
                Response.Redirect("login.aspx");
            else
                objLogin = (Models.login)Session["objLogin"];
            
            if (!IsPostBack)
            {
                mvMain.SetActiveView(vRekapSkema);
                isiDdlThnPelaksanaan();
                isiGvRekapSkema();
            }
        }

        #region Rekap Skema

private void isiDdlThnPelaksanaan()
{
    ddlTahunPelaksanaan.Items.Clear();
    int thnSKg = int.Parse(DateTime.Now.Year.ToString());
    for (int i = thnSKg; i >= 2022; i--)
    {
        ddlTahunPelaksanaan.Items.Add(new System.Web.UI.WebControls.ListItem(i.ToString(), i.ToString()));
    }
    ddlTahunPelaksanaan.SelectedIndex = 0;
}

private void isiGvRekapSkema()
{
    var dt = new DataTable();
    if (modelPerbaikanUsulan.listRekapSkema(ref dt, ddlTahunPelaksanaan.SelectedValue, 
        KD_JENIS_KEGIATAN, objLogin.idInstitusi))
    {
        gvRekapSkema.DataSource = dt;
        gvRekapSkema.DataBind();

        Label lblTotalJmlUsulan = ((Label)gvRekapSkema.FooterRow.FindControl("lblTotalJmlUsulan"));
        Label lblTotalJmlSdhMemperbaiki = ((Label)gvRekapSkema.FooterRow.FindControl("lblTotalJmlSdhMemperbaiki"));
        Label lblTotalJmlBlmMemperbaiki = ((Label)gvRekapSkema.FooterRow.FindControl("lblTotalJmlBlmMemperbaiki"));
        if (dt.Rows.Count > 0)
        {
            var totalJmlUsulan = dt.Compute("SUM(jml_usulan)", string.Empty);
            lblTotalJmlUsulan.Text = decimal.Parse(totalJmlUsulan.ToString()).ToString("N0");

            var totalJmlSdhMemperbaiki = dt.Compute("SUM(jml_sdh_memperbaiki)", string.Empty);
            lblTotalJmlSdhMemperbaiki.Text = decimal.Parse(totalJmlSdhMemperbaiki.ToString()).ToString("N0");

            var totalJmlBlmMemperbaiki = dt.Compute("SUM(jml_blm_memperbaiki)", string.Empty);
            lblTotalJmlBlmMemperbaiki.Text = decimal.Parse(totalJmlBlmMemperbaiki.ToString()).ToString("N0");

        }
        else
        {
            lblTotalJmlUsulan.Text = "0";
            lblTotalJmlSdhMemperbaiki.Text = "0";
            lblTotalJmlBlmMemperbaiki.Text = "0";
        }
    }
    else
    {
        noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan", modelPerbaikanUsulan.errorMessage);
    }
}

protected void ddlTahunPelaksanaan_SelectedIndexChanged(object sender, EventArgs e)
{
    isiGvRekapSkema();
}

protected void gvRekapSkema_RowCommand(object sender, GridViewCommandEventArgs e)
{
    if (e.CommandName == "detailRekapSkema")
    {
        int idx = Convert.ToInt32(e.CommandArgument.ToString());
        int idSkema = int.Parse(gvRekapSkema.DataKeys[idx]["id_skema"].ToString());
        string namaSkema = gvRekapSkema.DataKeys[idx]["nama_skema"].ToString();

        ViewState["IdSkema"] = idSkema;
        ViewState["NamaSkema"] = namaSkema;

        lblNamaSkemaDaftarPerbaikan.Text = ViewState["NamaSkema"].ToString();
        lblThnPelaksanaanDaftarPerbaikan.Text = ddlTahunPelaksanaan.Text.ToString();

        isiLvDaftarPerbaikan(int.Parse(ddlJmlBaris.SelectedValue), 0);
        tbPencarianDaftarPerbaikan.Text = string.Empty;
        mvMain.SetActiveView(vDaftarPerbaikanUsulan);
    }
}

#endregion

#region Detail usulan

protected void lbKembaliDaftarPerbaikan_Click(object sender, EventArgs e)
{
    tbPencarianDaftarPerbaikan.Text = string.Empty;
    rblStsPelaksanaan.SelectedIndex = 0;
    mvMain.SetActiveView(vRekapSkema);
    isiGvRekapSkema();
}

private void isiLvDaftarPerbaikan(int limit, int offset)
{
    if (modelPerbaikanUsulan.getJmlPerbaikanUsulan(objLogin.idInstitusi, ddlTahunPelaksanaan.SelectedValue,
        int.Parse(ViewState["IdSkema"].ToString()), rblStsPelaksanaan.SelectedValue,
        tbPencarianDaftarPerbaikan.Text, 0, 0))
    {
        lblJmlJudulDaftarPerbaikan.Text = modelPerbaikanUsulan.numOfRecords.ToString();
    }
    else
    {
        noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan", modelPerbaikanUsulan.errorMessage);
    }

    pagingPerbaikanUsulan.currentPage = offset;
    pagingPerbaikanUsulan.setPaging(limit, modelPerbaikanUsulan.numOfRecords);

    modelPerbaikanUsulan.currentPage = offset;
    modelPerbaikanUsulan.rowsPerPage = limit;

    DataTable dt = new DataTable();
    if (modelPerbaikanUsulan.listDaftarPerbaikanUsulan(ref dt, objLogin.idInstitusi, ddlTahunPelaksanaan.SelectedValue,
        int.Parse(ViewState["IdSkema"].ToString()), rblStsPelaksanaan.SelectedValue,
        tbPencarianDaftarPerbaikan.Text, int.Parse(ddlJmlBaris.SelectedValue), offset))
    {
        lvDaftarPerbaikan.DataSource = dt;
        lvDaftarPerbaikan.DataBind();
    }
    else
    {
        noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan", modelPerbaikanUsulan.errorMessage);
    }

    if (modelPerbaikanUsulan.numOfRecords < 1)
    {
        pagingPerbaikanUsulan.setPaging(limit, 1);
    }
}

protected void lbPencarianDaftarPerbaikan_Click(object sender, EventArgs e)
{
    isiLvDaftarPerbaikan(int.Parse(ddlJmlBaris.SelectedValue), 0);
}

protected void ddlJmlBaris_SelectedIndexChanged(object sender, EventArgs e)
{
    isiLvDaftarPerbaikan(int.Parse(ddlJmlBaris.SelectedValue), 0);
}

protected void rblStsPelaksanaan_SelectedIndexChanged(object sender, EventArgs e)
{
    isiLvDaftarPerbaikan(int.Parse(ddlJmlBaris.SelectedValue), 0);
}

protected void lbExcelDaftarPerbaikan_Click(object sender, EventArgs e)
{
    var dt = new DataTable();
    using (ExcelPackage pck = new ExcelPackage())
    {
        var fileName = string.Format("Perbaikan Usulan " + ViewState["NamaSkema"].ToString() + " Pendanaan Tahun " +
            ddlTahunPelaksanaan.SelectedItem + ".xlsx");
        if (modelPerbaikanUsulan.getExcelPerbaikanUsulan(ref dt, objLogin.idInstitusi, ddlTahunPelaksanaan.SelectedValue,
        int.Parse(ViewState["IdSkema"].ToString())))
        {
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Data");
            ws.Cells["A1"].LoadFromDataTable(dt, true, OfficeOpenXml.Table.TableStyles.Light4);

            //Autofit Column
            for (int i = 1; i <= dt.Columns.Count; i++)
            {
                ws.Column(i).AutoFit(10);
            }
        }
        else
        {
            noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan", modelPerbaikanUsulan.errorMessage);
            return;
        }

        HttpResponse httpResponse = Response;
        httpResponse.Clear();
        httpResponse.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        httpResponse.AddHeader("content-disposition", string.Format("attachment;filename=\"{0}\"", fileName));

        using (MemoryStream memoryStream = new MemoryStream())
        {
            pck.SaveAs(memoryStream);
            memoryStream.WriteTo(httpResponse.OutputStream);
            memoryStream.Close();
        }

        httpResponse.End();
        pck.Dispose();
    }
}

protected void lvDaftarPerbaikan_ItemDataBound(object sender, ListViewItemEventArgs e)
{
    if (e.Item.ItemType == ListViewItemType.DataItem)
    {
        DataRowView drv1 = (DataRowView)e.Item.DataItem;
        Label lblNo = (Label)e.Item.FindControl("lblNo");
        lblNo.Text = (e.Item.DataItemIndex + 1 + int.Parse(ddlJmlBaris.SelectedValue) * (pagingPerbaikanUsulan.currentPage)).ToString();

        LinkButton lbUnduhDokumenPerbaikan = (LinkButton)e.Item.FindControl("lbUnduhDokumenPerbaikan");
        string kd_sts_pelaksanaan = lvDaftarPerbaikan.DataKeys[e.Item.DataItemIndex]["kd_sts_pelaksanaan"].ToString();
        if (kd_sts_pelaksanaan == "1")
        {
            lbUnduhDokumenPerbaikan.ForeColor = System.Drawing.Color.Green;
            lbUnduhDokumenPerbaikan.Enabled = true;
        }
    }
}

protected void lvDaftarPerbaikan_ItemCommand(object sender, ListViewCommandEventArgs e)
{
    int rowIndex = int.Parse(e.CommandArgument.ToString());
    if (e.CommandName == "unduhDokumenPerbaikan")
    {
        string idUsulanKegiatan = lvDaftarPerbaikan.DataKeys[rowIndex]["id_usulan_kegiatan"].ToString();
        string idTransaksiKegiatan = lvDaftarPerbaikan.DataKeys[rowIndex]["id_transaksi_kegiatan"].ToString(); ;
        ktPdfUsulanPerbaikan.UnduhProposalLengkap(idUsulanKegiatan, idTransaksiKegiatan, "1");
    }
}

protected void pagingPerbaikanUsulan_PageChanging(object sender, EventArgs e)
{
    DataTable dt = new DataTable();
    modelPerbaikanUsulan.currentPage = pagingPerbaikanUsulan.currentPage;
    modelPerbaikanUsulan.rowsPerPage = int.Parse(ddlJmlBaris.SelectedValue);
    ViewState["currentPage"] = pagingPerbaikanUsulan.currentPage * int.Parse(ddlJmlBaris.SelectedValue);

    if (modelPerbaikanUsulan.listDaftarPerbaikanUsulan(ref dt, objLogin.idInstitusi, ddlTahunPelaksanaan.SelectedValue,
        int.Parse(ViewState["IdSkema"].ToString()), rblStsPelaksanaan.SelectedValue,
        tbPencarianDaftarPerbaikan.Text, int.Parse(ddlJmlBaris.SelectedValue),
        int.Parse(ViewState["currentPage"].ToString())))
    {
        lvDaftarPerbaikan.DataSource = dt;
        lvDaftarPerbaikan.DataBind();
    }
    else
    {
        noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan", modelPerbaikanUsulan.errorMessage);
    }
}

#endregion
    }
}
