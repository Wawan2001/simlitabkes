using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace simlitekkes.Models.PT
{
    public class monitoringPerbaikanUsulan : _abstractModels
    {
        public monitoringPerbaikanUsulan()
        {
            this.setInitValues();
        }

        public bool listRekapSkema(ref DataTable dataTable, string thn_pelaksanaan_kegiatan, 
            string kd_jenis_kegiatan, Guid id_institusi)
        {
            bool isSuccess = false;

            string strSQL = $"SELECT * FROM hibah.list_rekap_skema_perbaikan_usulan_opt_pt('{thn_pelaksanaan_kegiatan}', " +
                $"'{kd_jenis_kegiatan}', '{id_institusi}');";

            isSuccess = this._db.FetchDataTable(strSQL, ref dataTable);
            if (!isSuccess)
                this._errorMessage = this._db.ErrorMessage;

            return isSuccess;

        }

        public bool listHasilReviewPerPT(ref DataTable dataTable, string kdHibah, string thnUsulan, string thnPelaksanaan, string kdTahapan, int idSkema, string pencarian)
        {
            bool isSuccess = false;
            string strSQL = string.Format(@"SELECT * FROM hibah.rekap_monitoring_hasil_reviewer_by_skema(@kdHibah, @thnUsulan, @thnPelaksanaan, @kdTahapan, @idSkema, @search, @limit, @offset);");
            isSuccess = this._db.FetchDataTable(strSQL, ref dataTable
                , new Npgsql.NpgsqlParameter("@kdHibah", kdHibah)
                , new Npgsql.NpgsqlParameter("@thnUsulan", thnUsulan)
                , new Npgsql.NpgsqlParameter("@thnPelaksanaan", thnPelaksanaan)
                , new Npgsql.NpgsqlParameter("@kdTahapan", kdTahapan)
                , new Npgsql.NpgsqlParameter("@idSkema", idSkema)
                , new Npgsql.NpgsqlParameter("@search", pencarian)
                , new Npgsql.NpgsqlParameter("@limit", this._rowsPerPage)
                , new Npgsql.NpgsqlParameter("@offset", this._currentPage * this._rowsPerPage)
                );
            if (!isSuccess)
                this._errorMessage = this._db.ErrorMessage;
            return isSuccess;
        }

        public bool getJmlPerbaikanUsulan(Guid id_institusi, string thn_pelaksanaan_kegiatan, 
            int id_skema, string kd_sts_pelaksanaan, string nama, int limit, int offset)
        {
            bool isSuccess = false;

            string strSQL = $"SELECT count(*)::int AS jml_data " +
                $"FROM hibah.list_monitoring_perbaikan_usulan_opt_pt('{id_institusi}', '{thn_pelaksanaan_kegiatan}', " +
                $"{id_skema}, '{kd_sts_pelaksanaan}', '{nama}',  {limit}, {offset});";

            isSuccess = this._db.fetchDataSkalar(strSQL, ref this._numOfRecords);
            if (!isSuccess)
                this._errorMessage = this._db.ErrorMessage;

            return isSuccess;
        }

        public bool listDaftarPerbaikanUsulan(ref DataTable dataTable, Guid id_institusi, 
            string thn_pelaksanaan_kegiatan, int id_skema, string kd_sts_pelaksanaan, string nama, int limit, int offset)
        {
            bool isSuccess = false;

            string strSQL = $"SELECT * FROM hibah.list_monitoring_perbaikan_usulan_opt_pt('{id_institusi}', '{thn_pelaksanaan_kegiatan}', " +
                $"{id_skema}, '{kd_sts_pelaksanaan}', '{nama}',  {limit}, {offset});";

            isSuccess = this._db.FetchDataTable(strSQL, ref dataTable);
            if (!isSuccess)
                this._errorMessage = this._db.ErrorMessage;

            return isSuccess;
        }

        public bool getExcelPerbaikanUsulan(ref DataTable dataTable, Guid id_institusi, 
            string thn_pelaksanaan_kegiatan, int id_skema)
        {
            bool isSuccess = false;

            string strSQL = $"SELECT nidn, nama, judul, nama_singkat_skema, sts_pelaksanaan, tahun_ke " +
                $"FROM hibah.list_monitoring_perbaikan_usulan_opt_pt('{id_institusi}', '{thn_pelaksanaan_kegiatan}', {id_skema});";

            isSuccess = this._db.FetchDataTable(strSQL, ref dataTable);
            if (!isSuccess)
                this._errorMessage = this._db.ErrorMessage;

            return isSuccess;
        }
    }
}