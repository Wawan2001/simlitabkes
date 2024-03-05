using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simlitekkes.UserControls.OperatorPT
{
    public partial class menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void setLaman(int kodeLaman)
        {
            Session["page"] = kodeLaman;
            Response.Redirect("Main.aspx");
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Clear();
            Response.Redirect("~/Login.aspx");

        }

        protected void lbBeranda_Click(object sender, EventArgs e)
        {
            setLaman(1);
        }

        #region Menu Usulan Kegiatan

        protected void lbRekapUsulanBaru_Click(object sender, EventArgs e)
        {
            setLaman(11);
        }

        protected void lbRekapUsulanBaruAbdimas_Click(object sender, EventArgs e)
        {
            setLaman(12);
        }
        #endregion

        #region Penilaian

        protected void lbPenugasanReviewer_Click(object sender, EventArgs e)
        {
            setLaman(21);
        }

        protected void lbPlottingReviewer_Click(object sender, EventArgs e)
        {
            setLaman(22);
        }

        protected void lbPenetapanTahapan_Click(object sender, EventArgs e)
        {
            setLaman(23);
        }

        protected void lbPenetapanUsulanLanjutan_Click(object sender, EventArgs e)
        {
            setLaman(24);
        }

        #endregion

        #region Monitoring Kegiatan

        protected void lbMonitoringHasilReview_Click(object sender, EventArgs e)
        {
            setLaman(31);
        }

        protected void lbMonitoringSPTJB_Click(object sender, EventArgs e)
        {
            setLaman(32);
        }

        protected void lbMonitoringLapKemajuan_Click(object sender, EventArgs e)
        {
            setLaman(33);
        }

        protected void lbMonitoringMonevEksternal_Click(object sender, EventArgs e)
        {
            setLaman(34);
        }

        protected void lbMonitoringPerbaikanProposal_Click(object sender, EventArgs e)
        {
            setLaman(36);
        }

        protected void lbMonitoringLapAkhirTahun_Click(object sender, EventArgs e)
        {
            //setLaman(35);
            CleanSession();
            Session["page"] = 35;
            Response.Redirect("Main.aspx");
        }

        private void CleanSession()
        {
            if (Session["usulan_kegiatan"] != null)
                Session.Remove("usulan_kegiatan");

        }

        #endregion

        #region Data Pendukung

        protected void lbProfilLembaga_Click(object sender, EventArgs e)
        {
            setLaman(41);
        }
        protected void lbSinkronisasi_Click(object sender, EventArgs e)
        {
            setLaman(42);
        }
        protected void lbKelolaTendikNonDosen_Click(object sender, EventArgs e)
        {
            setLaman(43);
        }
        protected void lbPencarianAkunDosen_Click(object sender, EventArgs e)
        {
            setLaman(44);
        }
        protected void lbUnggahDokumenRenstra_Click(object sender, EventArgs e)
        {
            setLaman(45);
        }
        protected void lbBidangUnngulanPT_Click(object sender, EventArgs e)
        {
            setLaman(46);
        }
        protected void lbTopikUnggulanPT_Click(object sender, EventArgs e)
        {
            setLaman(47);
        }
        #endregion

        #region Luaran Tambahan

        protected void lbPlottingLuaranTambahan_Click(object sender, EventArgs e)
        {
            setLaman(51);
        }

        #endregion

        //protected void lbPlottingReviewer3rd_Click(object sender, EventArgs e)
        //{
        //    setLaman(25);
        //}
        //protected void lbReviewerInternal_Click(object sender, EventArgs e)
        //{
        //    setLaman(21);
        //}

        //protected void lbPenugasanReviewerLanjutan_Click(object sender, EventArgs e)
        //{
        //    setLaman(33);
        //}

        //protected void lbPlottingReviewerLanjutan_Click(object sender, EventArgs e)
        //{
        //    setLaman(34);
        //}

        //protected void lbHasilReview_Click(object sender, EventArgs e)
        //{
        //    setLaman(36);
        //}
    }
}
