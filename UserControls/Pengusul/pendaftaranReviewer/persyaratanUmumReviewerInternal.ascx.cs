﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using simlitekkes.Models;
using simlitekkes.Models.Pengusul;
using simlitekkes.UIControllers;
using System.IO;

namespace simlitekkes.UserControls.Pengusul.pendaftaranReviewer
{
    public partial class persyaratanUmumReviewerInternal : System.Web.UI.UserControl
    {
        Models.Pengusul.persyaratanUmumPendaftaranReviewer objPersyaratan = new Models.Pengusul.persyaratanUmumPendaftaranReviewer();
        Models.Pengusul.berandaPengusul objBerandaPengusul = new Models.Pengusul.berandaPengusul();

        login objLogin;
        uiNotify noty = new uiNotify();
        uiDropdownList objDdl = new uiDropdownList();
        uiModal objModal = new uiModal();
        public event EventHandler childEventEdit;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void showPanelReviewerBaru(bool isShow)
        {
            mvPersyaratanWajibPenelitianInternal.SetActiveView(vPersyaratanWajibPenelitianInternal);
        }

        public int isiDataPersyaratanUmum()
        {
            objLogin = (login)Session["objLogin"];
            string id_personal = objLogin.idPersonal;

            // Cek Eligibilitas Dosen
            var dtCekDataDosen = new DataTable();
            if (objPersyaratan.getCekDataDosen(ref dtCekDataDosen, id_personal))
            {
                if (dtCekDataDosen.Rows.Count > 0)
                {
                    string kd_sts_eligible_dosen = dtCekDataDosen.Rows[0]["kd_sts_eligible_dosen"].ToString();
                    ViewState["kdStsEligibleDosen"] = kd_sts_eligible_dosen;
                    string statusGabungan = dtCekDataDosen.Rows[0]["status_gabungan"].ToString();
                    ViewState["statusGabungan"] = statusGabungan;
                    string status_aktif_dosen = dtCekDataDosen.Rows[0]["status_aktif_dosen"].ToString();
                    ViewState["status_aktif_dosen"] = status_aktif_dosen;
                }
            }

            // Isi Data Dosen
            var dtPersonal = new DataTable();
            if (objBerandaPengusul.getPersonal(ref dtPersonal, id_personal))
            {
                if (dtPersonal.Rows.Count > 0)
                {
                    lblNamaInstitusi.Text = dtPersonal.Rows[0]["nama_institusi"].ToString();
                    lblNamaProdi.Text = dtPersonal.Rows[0]["nama_program_studi"].ToString();
                    lblKategoriProdi.Text = dtPersonal.Rows[0]["kategori_prodi"].ToString();
                    lblJenjangPendidikan.Text = dtPersonal.Rows[0]["jenjang_pendidikan_tertinggi"].ToString();
                    lblJabatanFungsional.Text = dtPersonal.Rows[0]["jabatan_fungsional"].ToString();
                    lblStstusAktif.Text = dtPersonal.Rows[0]["status_aktif"].ToString();
                    lblHindex.Text = dtPersonal.Rows[0]["hindex"].ToString();

                    int idJabatanFungsional = int.Parse(dtPersonal.Rows[0]["id_jabatan_fungsional"].ToString());
                    ViewState["idJabatanFungsional"] = idJabatanFungsional;
                    int idJenjangPendidikanTertinggi = int.Parse(dtPersonal.Rows[0]["id_jenjang_pendidikan_tertinggi"].ToString());
                    ViewState["idJenjangPendidikanTertinggi"] = idJenjangPendidikanTertinggi;
                    int hindex = int.Parse(dtPersonal.Rows[0]["hindex"].ToString());
                    ViewState["hindex"] = hindex;

                    int idKategoriProgramStudi = int.Parse(dtPersonal.Rows[0]["id_kategori_program_studi"].ToString());
                    ViewState["idKategoriProgramStudi"] = idKategoriProgramStudi;

                    string isSeni = dtPersonal.Rows[0]["is_seni"].ToString();
                    ViewState["isSeni"] = isSeni;

                    string kdKlaster = dtPersonal.Rows[0]["kd_klaster"].ToString();
                    ViewState["kdKlaster"] = kdKlaster;
                }
            }

            // Cek Jumlah Ketua
            var dtJmlKetua = new DataTable();
            if (objPersyaratan.getCekJmlKetuaPenelitian(ref dtJmlKetua, id_personal))
            {
                if (dtJmlKetua.Rows.Count > 0)
                {
                    lblJmlPenelitian.Text = dtJmlKetua.Rows[0]["jml_ketua"].ToString();
                    int jmlKetua = int.Parse(dtJmlKetua.Rows[0]["jml_ketua"].ToString());
                    ViewState["jmlKetua"] = jmlKetua;
                }
            }

            // Cek Jumlah Penulis Pertama Artikel
            var dtJmlPenulisPertamaArtikel = new DataTable();
            if (objPersyaratan.getJmlPenulisPertamaArtikelJurnal(ref dtJmlPenulisPertamaArtikel, id_personal))
            {
                if (dtJmlPenulisPertamaArtikel.Rows.Count > 0)
                {
                    lblJmlArtikelPenulisPertama.Text = dtJmlPenulisPertamaArtikel.Rows[0]["jml_penulis_pertama"].ToString();
                    int jmlPenulisPertama = int.Parse(dtJmlPenulisPertamaArtikel.Rows[0]["jml_penulis_pertama"].ToString());
                    ViewState["jmlPenulisPertama"] = jmlPenulisPertama;
                }
            }

            // Cek Jumlah Penulis Anggota Artikel
            var dtJmlPenulisAnggotaArtikel = new DataTable();
            if (objPersyaratan.getJmlPenulisAnggotaArtikelJurnal(ref dtJmlPenulisAnggotaArtikel, id_personal))
            {
                if (dtJmlPenulisAnggotaArtikel.Rows.Count > 0)
                {
                    lblJmlArtikelPenulisAnggota.Text = dtJmlPenulisAnggotaArtikel.Rows[0]["jml_penulis_anggota"].ToString();
                }
            }

            // Cek Jumlah Paten
            var dtJmlPaten = new DataTable();
            if (objPersyaratan.getJmlHkiPenelitianGranted(ref dtJmlPaten, id_personal))
            {
                if (dtJmlPaten.Rows.Count > 0)
                {
                    lblJmlPatenGranted.Text = dtJmlPaten.Rows[0]["jml_paten"].ToString();
                    int jmlPaten = int.Parse(dtJmlPaten.Rows[0]["jml_paten"].ToString());
                    ViewState["jmlPaten"] = jmlPaten;
                }
            }

            var dtJmlPatenTerdaftar = new DataTable();
            if (objPersyaratan.getJmlHkiPenelitianTerdaftar(ref dtJmlPatenTerdaftar, id_personal))
            {
                if (dtJmlPatenTerdaftar.Rows.Count > 0)
                {
                    lblJmlPatenTerdaftar.Text = dtJmlPatenTerdaftar.Rows[0]["jml_paten"].ToString();
                    int jmlPaten = int.Parse(dtJmlPatenTerdaftar.Rows[0]["jml_paten"].ToString());
                    ViewState["jmlPaten"] = jmlPaten;
                }
            }

            //Cek Jumlah Karya Seni
            var dtJmlKaryaSeni = new DataTable();
            if (objPersyaratan.getJmlKaryaSeni(ref dtJmlKaryaSeni, id_personal))
            {
                if (dtJmlKaryaSeni.Rows.Count > 0)
                {
                    lblJmlKaryaSeni.Text = dtJmlKaryaSeni.Rows[0]["jml_karya_seni"].ToString();
                    int jmlKaryaSeni = int.Parse(dtJmlKaryaSeni.Rows[0]["jml_karya_seni"].ToString());
                    ViewState["jmlKaryaSeni"] = jmlKaryaSeni;
                }
            }

            // Cek Jumlah Penulis Pertama Prosiding
            var dtJmlPenulisPertamaProsiding = new DataTable();
            if (objPersyaratan.getJmlPenulisPertamaProsiding(ref dtJmlPenulisPertamaProsiding, id_personal))
            {
                if (dtJmlPenulisPertamaProsiding.Rows.Count > 0)
                {
                    lblJmlProsidingPenulisKetua.Text = dtJmlPenulisPertamaProsiding.Rows[0]["jml_penulis_pertama_prosiding"].ToString();
                    int jmlPenulisPertamaProsiding = int.Parse(dtJmlPenulisPertamaProsiding.Rows[0]["jml_penulis_pertama_prosiding"].ToString());
                    ViewState["jmlPenulisPertamaProsiding"] = jmlPenulisPertamaProsiding;
                }
            }

            // Cek Jumlah Penulis Anggota Prosiding
            var dtJmlPenulisAnggotaProsiding = new DataTable();
            if (objPersyaratan.getJmlPenulisAnggotaProsiding(ref dtJmlPenulisAnggotaProsiding, id_personal))
            {
                if (dtJmlPenulisAnggotaProsiding.Rows.Count > 0)
                {
                    lblJmlProsidingAnggota.Text = dtJmlPenulisAnggotaProsiding.Rows[0]["jml_penulis_anggota_prosiding"].ToString();
                    int jmlPenulisAnggotaProsiding = int.Parse(dtJmlPenulisAnggotaProsiding.Rows[0]["jml_penulis_anggota_prosiding"].ToString());
                    ViewState["jmlPenulisAnggotaProsiding"] = jmlPenulisAnggotaProsiding;
                }
            }

            int totalSyarat = konfigurPersyaratan();
            return totalSyarat;
        }

        private int konfigurPersyaratan()
        {
            string kdStsEligibleDosen = ViewState["kdStsEligibleDosen"].ToString();
            string statusGabungan = ViewState["statusGabungan"].ToString();
            int idJenjangPendidikanTertinggi = int.Parse(ViewState["idJenjangPendidikanTertinggi"].ToString());
            string kdKlaster = ViewState["kdKlaster"].ToString();

            int totalSyarat = 0;

            // Cek eligibilitas data dosen
            if (kdStsEligibleDosen == "1")
            {
                infoEligibilitasDosen.Visible = false;
                totalSyarat++;
            }
            else
            {
                infoEligibilitasDosen.Visible = true;
                lblInfoEligibilitasDosen.Text = statusGabungan;
            }

            // Cek Jenjang Pendidikan dan Jabatan Fungsional
            if (idJenjangPendidikanTertinggi == 7)
            {
                infoJenjangPendidikan.Visible = false;
                totalSyarat++;
            }
            else
            {
                infoJenjangPendidikan.Visible = true;
            }

            // Cek Klaster Pengusul
            if (kdKlaster == "G")
            {
                infoKlaster.Visible = true;
            }
            else
            {
                infoKlaster.Visible = false;
                totalSyarat++;
            }
            

            return totalSyarat;
        }

        protected void lbEditKaryaSeni_Click(object sender, EventArgs e)
        {
            if (childEventEdit != null)
                childEventEdit(sender, null);
        }
        public void setEditable(bool isVisible)
        {
            lbEditKaryaSeni.Visible = isVisible;
        }

    }
}