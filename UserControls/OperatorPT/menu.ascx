<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menu.ascx.cs" Inherits="simlitekkes.UserControls.OperatorPT.menu" %>
<ul class="metismenu">
    <li class="nav-label">Menu Utama</li>
    <li class="mm-active">
        <asp:LinkButton runat="server" ID="lbBeranda" OnClick="lbBeranda_Click">
            <i class="typcn typcn-home-outline mr-2"></i>Beranda
        </asp:LinkButton>
    </li>
    <li>
        <a class="has-arrow material-ripple" href="#">
            <i class="typcn typcn-beaker mr-2"></i>
            Usulan Kegiatan
        </a>
        <ul class="nav-second-level">
            <li>
                <asp:LinkButton runat="server" ID="lbRekapUsulanBaru" OnClick="lbRekapUsulanBaru_Click">
                    <i class="fas fa-list mr-2"></i>Usulan Baru
                </asp:LinkButton>
                <asp:LinkButton runat="server" ID="lbRekapUsulanBaruAbdimas" OnClick="lbRekapUsulanBaruAbdimas_Click">
                    <i class="fas fa-list mr-2"></i>Usulan Baru Abdimas
                </asp:LinkButton>
            </li>
        </ul>
    </li>
    <li>
        <a class="has-arrow material-ripple" href="#">
            <i class="typcn typcn-beaker mr-2"></i>
            Penilaian
        </a>
        <ul class="nav-second-level">
            <li>
                <asp:LinkButton runat="server" ID="lbPenugasanReviewer" OnClick="lbPenugasanReviewer_Click">
                    <i class="fas fa-list mr-2"></i>Penugasan Reviewer
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbPlottingReviewer" OnClick="lbPlottingReviewer_Click">
                    <i class="fas fa-list mr-2"></i>Plotting Reviewer
                </asp:LinkButton>
            </li>
            <%--            <li>
                <asp:LinkButton runat="server" ID="lbPlottingReviewer3rd" OnClick="lbPlottingReviewer3rd_Click">
                    <i class="fas fa-list mr-2"></i>Plotting Reviewer (3rd)
                </asp:LinkButton>
            </li>--%>
            <li>
                <asp:LinkButton runat="server" ID="lbPenetapanTahapan" OnClick="lbPenetapanTahapan_Click">
                    <i class="fas fa-list mr-2"></i>Penetapan Usulan Baru
                </asp:LinkButton>
            </li>
             <li>
                <asp:LinkButton runat="server" ID="lbPenetapanUsulanLanjutan" OnClick="lbPenetapanUsulanLanjutan_Click">
                    <i class="fas fa-list mr-2"></i>Penetapan Usulan Lanjutan
                </asp:LinkButton>
            </li>
            <%--            <li>
                <asp:LinkButton runat="server" ID="lbHasilReview" OnClick="lbHasilReview_Click">
                    <i class="fas fa-list mr-2"></i>Hasil Review
                </asp:LinkButton>
            </li>--%>
        </ul>
    </li>
    <li>
        <a class="has-arrow material-ripple" href="#">
            <i class="typcn typcn-beaker mr-2"></i>
            Monitoring Kegiatan
        </a>
        <ul class="nav-second-level">
            <li>
                <asp:LinkButton runat="server" ID="lbMonitoringHasilReview" OnClick="lbMonitoringHasilReview_Click">
                    <i class="fas fa-list mr-2"></i>Hasil Review
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbMonitoringLapKemajuan" OnClick="lbMonitoringLapKemajuan_Click">
                    <i class="fas fa-list mr-2"></i>Laporan Kemajuan
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbMonitoringMonevEksternal" OnClick="lbMonitoringMonevEksternal_Click">
                    <i class="fas fa-list mr-2"></i>Hasil Monev Eksternal
                </asp:LinkButton>
            </li>
             <li>
                <asp:LinkButton runat="server" ID="lbMonitoringLapAkhirTahun" OnClick="lbMonitoringLapAkhirTahun_Click">
                    <i class="fas fa-list mr-2"></i>Laporan Akhir Tahun
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbMonitoringPerbaikanProposal" OnClick="lbMonitoringPerbaikanProposal_Click">
                    <i class="fas fa-list mr-2"></i>Perbaikan Proposal
                </asp:LinkButton>
</li>
        </ul>
    </li>
    <li>
        <a class="has-arrow material-ripple" href="#">
            <i class="typcn typcn-beaker mr-2"></i>
            Data Pendukung
        </a>
        <ul class="nav-second-level">
            <li>
                <asp:LinkButton runat="server" ID="lbProfilLembaga" OnClick="lbProfilLembaga_Click">
                    <i class="fas fa-list mr-2"></i>Profil Lembaga
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbSinkronisasi" OnClick="lbSinkronisasi_Click">
                    <i class="fas fa-list mr-2"></i>Sinkronisasi Dosen
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbKelolaTendikNonDosen" OnClick="lbKelolaTendikNonDosen_Click">
                    <i class="fas fa-list mr-2"></i>Kelola Tendik Non-Dosen
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbPencarianAkunDosen" OnClick="lbPencarianAkunDosen_Click">
                    <i class="fas fa-list mr-2"></i>Pencarian Akun Dosen
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbUnggahDokumenRenstra" OnClick="lbUnggahDokumenRenstra_Click">
                    <i class="fas fa-list mr-2"></i>Unggah Dokumen Renstra
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbBidangUnngulanPT" OnClick="lbBidangUnngulanPT_Click">
                    <i class="fas fa-list mr-2"></i>Bidang Unggulan PT
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton runat="server" ID="lbTopikUnggulanPT" OnClick="lbTopikUnggulanPT_Click">
                    <i class="fas fa-list mr-2"></i>Topik Unggulan PT
                </asp:LinkButton>
            </li>
        </ul>
    </li>
    <li>
        <asp:LinkButton runat="server" ID="lbLogout" OnClick="lbLogout_Click">
            <i class="typcn typcn-arrow-minimise mr-2"></i>Logout
        </asp:LinkButton>
    </li>
</ul>
