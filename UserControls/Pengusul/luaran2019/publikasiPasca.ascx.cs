﻿using simlitekkes.UIControllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simlitekkes.UserControls.Pengusul.luaran2019
{
    public partial class publikasiPasca : System.Web.UI.UserControl
    {
        Models.Pengusul.luaran objLuaran = new Models.Pengusul.luaran();
        public event EventHandler OnChildEventBatal;
        uiNotify noty = new uiNotify();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void init(string kd_kategori_jenis_luaran, string id_usulan, string tahun_ke, int id_skema, string idKelompokLuaran)
        {
            ViewState["id_usulan"] = id_usulan;
            ViewState["tahun_ke"] = tahun_ke;
            ViewState["kd_kategori_jenis_luaran"] = kd_kategori_jenis_luaran;
            ViewState["id_skema"] = id_skema;
            ViewState["id_kelompok_luaran"] = idKelompokLuaran;
            lblThnKe.Text = tahun_ke;
            Label1.Text = tahun_ke;

            DataTable dt = new DataTable();
            objLuaran.ListJenisLuaran2(ref dt, kd_kategori_jenis_luaran, id_skema, int.Parse(idKelompokLuaran));
            ddlJenisLuaran.Items.Clear();
            ddlJenisLuaran.AppendDataBoundItems = true;
            //ddlJenisLuaran.Items.Add(new ListItem("-- Pilih --", "0"));
            ddlJenisLuaran.DataSource = dt;
            ddlJenisLuaran.DataBind();
            ddlJenisLuaran.Enabled = true;
            tbRencanaNamaJurnal.Text = "";

            DataTable dt2 = new DataTable();
            objLuaran.ListTargetStatusLuaran(ref dt2, kd_kategori_jenis_luaran);
            ddlTargetStatusLuaran.DataSource = dt2;
            ddlTargetStatusLuaran.DataBind();
            if (dt2.Rows.Count > 0)
            {
                ddlTargetStatusLuaran.ClearSelection();
                ddlTargetStatusLuaran.Items.FindByValue(dt2.Rows[0]["id_target_capaian_luaran"].ToString()).Selected = true;
                isiInfoBuktiLuaran1();
            }
        }

        public void setData(Guid p_id_luaran_dijanjikan, string tahun_ke,
            string p_id_jenis_luaran = "", string kd_kategori_jenis_luaran = "")
        {
            ViewState["id_luaran_dijanjikan"] = p_id_luaran_dijanjikan;
            ViewState["id_jenis_luaran"] = p_id_jenis_luaran;
            lblThnKe.Text = tahun_ke;
            tbRencanaNamaJurnal.Text = "";
            if (p_id_jenis_luaran != "") // untuk update data
            {
                ddlJenisLuaran.ClearSelection();
                ddlJenisLuaran.Items.FindByValue(p_id_jenis_luaran.ToString()).Selected = true;
                ddlJenisLuaran.Enabled = false;
                DataTable dt = new DataTable();
                objLuaran.getLuaranDijanjikan(ref dt, p_id_luaran_dijanjikan);
                if (dt.Rows.Count > 0)
                {
                    tbRencanaNamaJurnal.Text = dt.Rows[0]["keterangan"].ToString();
                    ddlTargetStatusLuaran.ClearSelection();
                    ddlTargetStatusLuaran.Items.FindByValue(dt.Rows[0]["id_target_capaian_luaran"].ToString()).Selected = true;
                    isiInfoBuktiLuaran1();
                }
            }
            else
            {
                ddlJenisLuaran.ClearSelection();
                ddlJenisLuaran.SelectedIndex = 0;
                ddlJenisLuaran.Enabled = true;
            }

        }

        protected void lbSimpan_Click(object sender, EventArgs e)
        {
            if (tbRencanaNamaJurnal.Text.Trim() == "")
            {
                noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan",
                    "Rencana nama jurnal Luaran ke 1 belum diisi");
                return;
            }
            if (TextBox1.Text.Trim() == "")
            {
                noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan",
                    "Rencana nama jurnal Luaran ke 2 belum diisi.");
                return;
            }

            if (DropDownList2.SelectedValue.Trim() == "0")
            {
                noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan",
                    "Target Luaran ke 2 belum diisi.");
                return;
            }

            Guid p_id_luaran_dijanjikan = Guid.Empty;
            if (ViewState["id_luaran_dijanjikan"] != null)
                if (ViewState["id_luaran_dijanjikan"].ToString().Trim() != "")
                    p_id_luaran_dijanjikan = Guid.Parse(ViewState["id_luaran_dijanjikan"].ToString());
            Guid p_id_usulan = Guid.Parse(ViewState["id_usulan"].ToString());

            //int p_id_kelompok_luaran = 1; // 1=wajib, 2=tambahan
            int p_id_kelompok_luaran = int.Parse(ViewState["id_kelompok_luaran"].ToString());
            int tahun_ke = int.Parse(ViewState["tahun_ke"].ToString());


            objLuaran.insupLuaranWajibDijanjikanDasar_xii(
                p_id_luaran_dijanjikan,
              p_id_usulan,
              int.Parse(DropDownList1.SelectedValue),
              p_id_kelompok_luaran,
              tahun_ke,
              int.Parse(DropDownList2.SelectedValue),
              new string[] { TextBox1.Text });
            

            if (objLuaran.insupLuaranWajibDijanjikanDasar_xii(
                p_id_luaran_dijanjikan,
              p_id_usulan,
              int.Parse(ddlJenisLuaran.SelectedValue),
              p_id_kelompok_luaran,
              tahun_ke,
              int.Parse(ddlTargetStatusLuaran.SelectedValue),
              new string[] { tbRencanaNamaJurnal.Text }
            ))
            {
                //ViewState["id_luaran_dijanjikan"] = new_id_luaran_dijanjikan;
                noty.Notify(this.Page, uiNotify.NotifyType.success, "Informasi",
                       "Simpan luaran publikasi jurnal berhasil.");
                //lbBatal.Text = "Kembali";
                if (OnChildEventBatal != null)
                    OnChildEventBatal(sender, null);
            }
            else
            {
                noty.Notify(this.Page, uiNotify.NotifyType.error, "Terjadi Kesalahan",
                    "Simpan luaran publikasi jurnal gagal. Silakan hubungi administrator.");
            }
        }

        protected void lbBatal_Click(object sender, EventArgs e)
        {
            if (OnChildEventBatal != null)
                OnChildEventBatal(sender, null);
        }

        protected void ddlTargetStatusLuaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiInfoBuktiLuaran1();
        }

        private void isiInfoBuktiLuaran1()
        {
            string thnKe = ViewState["tahun_ke"].ToString();


            DataTable dt = new DataTable();
            objLuaran.ListInfoBuktiLuaran(ref dt, ddlJenisLuaran.SelectedValue,
                int.Parse(thnKe),
                int.Parse(ddlTargetStatusLuaran.SelectedValue),
                int.Parse(ViewState["id_skema"].ToString()),
                int.Parse(ViewState["id_kelompok_luaran"].ToString())
                );
            if (dt.Rows.Count > 0)
            {
                string info = "";
                info += dt.Rows[0]["get_info_bukti_luaran_26_juli"].ToString();

                lblInfoBuktiLuaran.Text = info;
            }
        }

        private void isiInfoBuktiLuaran2()
        {
            string thnKe = ViewState["tahun_ke"].ToString();


            DataTable dt = new DataTable();
            objLuaran.ListInfoBuktiLuaran(ref dt, DropDownList1.SelectedValue,
                int.Parse(thnKe),
                int.Parse(DropDownList2.SelectedValue),
                int.Parse(ViewState["id_skema"].ToString()),
                int.Parse(ViewState["id_kelompok_luaran"].ToString())
                );
            if (dt.Rows.Count > 0)
            {
                string info = "";
                info += dt.Rows[0]["get_info_bukti_luaran_26_juli"].ToString();

                Label2.Text = info;
            }
        }



        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiInfoBuktiLuaran2();
        }
    }
}