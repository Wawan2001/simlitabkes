using System;

namespace simlitekkes
{
    public partial class Main1 : System.Web.UI.Page
    {
        Models.login objLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["objLogin"] == null)
                Response.Redirect("Login.aspx");
            else
                objLogin = (Models.login)Session["objLogin"];
            string page = Session["page"].ToString();
            switch (objLogin.idPeran)
            {
                //===========================================================
                case 1:     // Administrator
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/sinkronisasiPerguruanTinggi.ascx"));
                            break;
                        case "3":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/generateTokenPddikti.ascx"));
                            break;
                        case "4":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/sinkronisasiProdi.ascx"));
                            break;
                        case "5":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/rabKelompokBiaya.ascx"));
                            break;
                        case "6":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/rabKomponenBelanja.ascx"));
                            break;
                        case "7":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/kategoriMitra.ascx"));
                            break;
                        case "8":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/mitraWajib.ascx"));
                            break;
                        case "9":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/kategoriJenisLuaran.ascx"));
                            break;
                        case "10":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/jenisLuaran.ascx"));
                            break;
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/buktiLuaran.ascx"));
                            break;
                        case "12":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/peranPenulis.ascx"));
                            break;
                        case "13":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/jenisProsiding.ascx"));
                            break;
                        case "14":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/jenisSKDokumen.ascx"));
                            break;
                        case "15":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/dataPendukungPusat.ascx"));
                            break;
                        case "16":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/pengumuman.ascx"));
                            break;
                        case "17":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/runningText.ascx"));
                            break;
                        case "18":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/personalPPSDM.ascx"));
                            break;
                        case "19":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/jadwalKegiatanperTahapan.ascx"));
                            break;
                        case "20":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/klasterPerguruanTinggi.ascx"));
                            break;
                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/kategoriSBK.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Admin/peran.ascx"));
                            break;

                    }
                    break;
                case 9:     // kepala lembaga Penelitian
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/persetujuan.ascx"));
                            break;
                        case "3":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/persetujuanLanjutan.ascx"));
                            break;
                        case "4":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/persetujuanPengabdian.ascx"));
                            break;
                    }
                    break;
                case 10:     // kepala lembaga Pengabdian
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/persetujuanPengabdian.ascx"));
                            break;
                        case "3":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/KepalaLembaga/persetujuanPengabdianLanjutan.ascx"));
                            break;
                    }
                    break;
                //===========================================================
                case 37:     // Pengusul
                case 39:     // Pengusul Non Dosen KemenRistekDikti
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/usulanBaru.ascx"));
                            break;
                        case "3":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/usulanLanjutan.ascx"));
                            break;
                        case "4":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/laporanKemajuan.ascx"));
                            break;
                        case "5":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/laporanAkhir.ascx"));
                            break;
                        case "6":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/arsip.ascx"));
                            break;
                        case "7":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/PerbaikanProposal/perbaikanProposal.ascx"));
                            break;
                        case "8":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/pendanaan2021/usulanBaru.ascx"));
                            break;

                        //==============================================================================================
                        case "10":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/usulanBaruPengabdian.ascx"));
                            break;
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/usulanLanjutanPengabdian.ascx"));
                            break;

                        //==============================================================================================
                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/riwayatUsulan.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/konfirmasiPersetujuan.ascx"));
                            break;
                        case "31":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/rekapLuaran.ascx"));
                            break;

                        case "32":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/pendaftaranReviewer/pendaftaranReviewer.ascx"));
                            break;
                        case "33":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/pendaftaranReviewer/pendaftaranReviewerInternal.ascx"));
                            break;
                        case "34":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/pendaftaranReviewer/pendaftaranReviewerPpm.ascx"));
                            break;

                        //==============================================================================================
                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/pengembalianDana.ascx"));
                            break;
                        case "42":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/tanggungJawabBelanja.ascx"));
                            break;
                        case "43":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Pengusul/catatanHarian.ascx"));
                            break;
                    }
                    break;
                //===========================================================
                case 6:     // Operator PT
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/beranda.ascx"));
                            break;

                        // Usulan Kegiatan
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/rekapUsulanBaru.ascx"));
                            break;
                        case "12":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/rekapUsulanBaruPengabdian.ascx"));
                            break;

                        // Penilaian
                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/penugasanReviewerPT.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/plottingReviewerPT.ascx"));
                            break;
                        case "23":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/penetapanUsulanBaru.ascx"));
                            break;
                        case "24":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/penetapanUsulanLanjutan.ascx"));
                            break;

                        // Monitoring Kegiatan
                        case "31":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/hasilReview.ascx"));
                            break;
                        case "32":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/monitoringTanggungJawabBelanja.ascx"));
                            break;
                        case "33":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/monitoringLaporanKemajuan.ascx"));
                            break;
                        case "34":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/monitoringMonevEksternal.ascx"));
                            break;
                        case "35":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/monitoringLaporanAkhir.ascx"));
                            break;
                        case "36":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/monitoringPerbaikanUsulan.ascx"));
                            break;

                        // Data Pendukung
                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/profilLembaga.ascx"));
                            break;
                        case "42":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/sinkronisasiDosen.ascx"));
                            break;
                        case "43":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/tendikNonDosen.ascx"));
                            break;
                        case "44":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/pencarianAkunDosen.ascx"));
                            break;
                        case "45":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/unggahDokumenRenstra.ascx"));
                            break;
                        case "46":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/bidangUnggulanPt.ascx"));
                            break;
                        case "47":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/topikUnggulanPt.ascx"));
                            break;
                        case "53":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/formIdentitasTendikNonDosen.ascx"));
                            break;
                    }
                    break;

                //===========================================================
                case 40:     // Operator PT Abdimas
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/beranda.ascx"));
                            break;
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/rekapUsulanBaruPengabdian.ascx"));
                            break;
                        case "12":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/rekapUsulanLanjutanPengabdian.ascx"));
                            break;

                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/unggahSkReviewer.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/reviewerInternal.ascx"));
                            break;
                        case "23":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/penugasanReviewerPT.ascx"));
                            break;
                        case "24":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/plottingReviewerPT.ascx"));
                            break;
                        case "25":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/plottingReviewerPT3rd.ascx"));
                            break;

                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/sinkronisasiDosen.ascx"));
                            break;
                        case "42":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPT/pencarianAkunDosen.ascx"));
                            break;
                    }
                    break;
                //===========================================================
                case 55:     // Operator Penelitian Pusdik Kemkes
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/beranda.ascx"));
                            break;

                        // Start Penilaian
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/penugasanReviewer.ascx"));
                            break;
                        case "12":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/plottingReviewer.ascx"));
                            break;
                        case "13":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/penetapanUsulanBaru.ascx"));
                            break;                        
                        // End

                        // Start Monitoring
                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/rekapUsulanBaru.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/rekapUsulanlanjutan.ascx"));
                            break;
                        case "23":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/luaranTambahanDidanai.ascx"));
                            break;
                        case "24":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringPenugasanReviewer.ascx"));
                            break;
                        case "25":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringPlottingReviewer.ascx"));
                            break;
                        case "26":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringHasilReview.ascx"));
                            break;
                        case "27":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringPerbaikanPenelitian.ascx"));
                            break;
                        case "28":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringLaporanKemajuan.ascx"));
                            break;
                        case "29":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringLaporanAkhirTahun.ascx"));
                            break;
                        // End

                        //case "27":
                        //    phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/plottingReviewerAdministrasi.ascx"));
                        //    break;

                        // Start Data Pendukung

                        case "31":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/operatorPT.ascx"));
                            break;
                        case "32":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/daftarReviewer.ascx"));
                            break;
                        case "56":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/perubahanPersonil.ascx"));
                            break;
                        case "57":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/perubahanJudul.ascx"));
                            break;

                        // End

                        // Start Kakas Bantu

                        // End
                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/pengirimanUserPasswordOperator.ascx"));

                            break;
                        case "42":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/eksepsiPengusul.ascx"));
                            break;

                        // Start Monitoring pengabdian
                        case "51":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/rekapUsulanBaruPengabdian.ascx"));
                            break;
                        case "52":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringPenugasanReviewerPengabdian.ascx"));
                            break;
                        case "53":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringPlottingReviewerPengabdian.ascx"));
                            break;
                        case "54":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringHasilReviewPengabdian.ascx"));
                            break;
                        case "55":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitianPusdik/monitoringMonevEksternal.ascx"));
                            break;

                        
                    }
                    break;
                case 56:     // Operator DRPM Pengabdian
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/beranda.ascx"));
                            break;
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/rekapUsulanBaruPengabdian.ascx"));
                            break;
                        case "12":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/rekapUsulanLanjutanPengabdian.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/daftarReviewer.ascx"));
                            break;
                        case "23":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/penugasanReviewer.ascx"));
                            break;
                        case "24":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/plottingReviewer.ascx"));
                            break;
                        case "25":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/plottingReviewer3rd.ascx"));
                            break;
                        case "26":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/hasilReview.ascx"));
                            break;
                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/OperatorPenelitian/monitoringEvaluasiPpm.ascx"));
                            break;
                    }
                    break;
                case 4:     // Reviewer Nasional
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiAdministrasi.ascx"));
                            break;
                        case "3":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiAdministrasiPengabdian.ascx"));
                            break;
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiSubstansiPenelitian.ascx"));
                            break;
                        case "12":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiSubstansiPengabdian.ascx"));
                            break;
                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiSubstansiPenelitianLanjutan.ascx"));
                            break;
                        case "22":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiSubstansiPengabdianLanjutan.ascx"));
                            break;
                        case "31":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiPembahasanPenelitian.ascx"));
                            break;
                        case "32":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiPembahasanPengabdian.ascx"));
                            break;
                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/validasiLuaranTambahan.ascx"));
                            break;
                        case "51":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/monevPenelitian.ascx"));
                            break;
                        case "52":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/penilaianLuaran.ascx"));
                            break;

                    }
                    break;
                case 7:     // Reviewer PT/Kopertis
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiAdministrasi.ascx"));
                            break;
                        case "11":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiSubstansiPenelitian.ascx"));
                            break;
                        case "21":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiSubstansiPenelitianLanjutan.ascx"));
                            break;
                        case "31":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiPembahasanPenelitian.ascx"));
                            break;
                        case "32":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/evaluasiPembahasanPengabdian.ascx"));
                            break;
                        case "41":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/validasiLuaranTambahan.ascx"));
                            break;
                        case "51":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/monevPenelitian.ascx"));
                            break;
                        case "52":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/Reviewer/penilaianLuaran.ascx"));
                            break;
                    }
                    break;
                case 76:     //Operator Pengolah Data
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/optRisbangPengolahData/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/optRisbangPengolahData/temuan.ascx"));
                            break;
                    }
                    break;
                //===========================================================

                case 62: // Manajemen Risbang - Kasubdit Penelitian
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/ManajemenKasubdit/beranda.ascx"));
                            break;
                    }
                    break;
                //===========================================================

                case 63: // Manajemen Risbang - Kasubdit PPM
                    switch (page)
                    {
                        case "1":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/ManajemenKasubdit/beranda.ascx"));
                            break;
                        case "2":
                            phContentForm.Controls.Add(LoadControl("~/UserControls/ManajemenKasubdit/penetapanReviewerPpm.ascx"));
                            break;
                    }
                    break;
                //===========================================================
                // Tambahan Sementara Ketika Fungsi Login Belum Jalan
                default:
                    Session.RemoveAll();
                    Session.Clear();
                    Response.Redirect("~/Login.aspx");
                    break;
            }
        }
    }
}
