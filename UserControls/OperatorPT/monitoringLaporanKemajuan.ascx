﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="monitoringLaporanKemajuan.ascx.cs" Inherits="simlitekkes.UserControls.OperatorPT.monitoringLaporanKemajuan" %>
<%@ Register Src="~/UserControls/Pengusul/report/pdfLaporanKemajuanKontrol.ascx" TagName="ktPdfLaporanKemajuanKontrol" TagPrefix="uc" %>
<%@ Register Src="~/Helper/controlPaging.ascx" TagName="controlPaging" TagPrefix="asc" %>

<style>
    .table a {
        color: #415dfe;
    }

        .table a:hover {
            color: #8d9efe;
        }

    .table th {
        vertical-align: middle;
    }

    .custom_cell {
        font-weight: bold;
        color: #3e86f1;
    }
</style>

<asp:MultiView runat="server" ID="mvMain">
    <asp:View runat="server" ID="vRekapSkema">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12" style="margin-top: 0px; color: #313233e3;">
                    <h4>Monitoring Laporan Kemajuan</h4>
                </div>
                <div class="col-md-5">
                    <div class="form-inline p-t-5 float-left">
                        <div class="form-group">
                            Tahun Pendanaan&nbsp;
                        <asp:DropDownList ID="ddlTahunPelaksanaan" runat="server" AutoPostBack="True"
                            OnSelectedIndexChanged="ddlTahunPelaksanaan_SelectedIndexChanged" CssClass="form-control input-sm">
                        </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="col-md-12 mt-3">
                    <div class="table-responsive">
                        <asp:GridView ID="gvRekapSkema" runat="server" GridLines="None"
                            CssClass="table table-striped table-hover table-bordered"
                            DataKeyNames="id_skema, nama_skema"
                            ShowHeader="true" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False"
                            OnRowCommand="gvRekapSkema_RowCommand">
                            <Columns>
                                <asp:TemplateField HeaderText="No." HeaderStyle-CssClass="text-center" HeaderStyle-Width="5%" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNoRekapSkema" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nama Skema" HeaderStyle-Width="55%" HeaderStyle-HorizontalAlign="Left" HeaderStyle-VerticalAlign="Middle">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbNamaSkemaRekapSkema" runat="server" Visible="true" CommandName="detailRekapSkema"
                                            Text='<%# Bind("nama_skema") %>' CommandArgument='<%# Container.DataItemIndex %>'
                                            CssClass="custom_cell" ToolTip="Tampilkan Detail"></asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sudah Unggah" HeaderStyle-CssClass="text-right" HeaderStyle-Width="10%" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                                    <ItemTemplate>
                                        <asp:Label ID="lblJmlSdhUnggahRekapSkema" runat="server" Text='<%# Bind("jml_sdh_unggah") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Belum Unggah" HeaderStyle-CssClass="text-right" HeaderStyle-Width="10%" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                                    <ItemTemplate>
                                        <asp:Label ID="lblJmlBlmUnggahRekapSkema" runat="server" Text='<%# Bind("jml_blm_unggah") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                <strong>DATA TIDAK DITEMUKAN</strong>
                            </EmptyDataTemplate>
                            <EmptyDataRowStyle CssClass="text-center" HorizontalAlign="Center" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </asp:View>
    <asp:View runat="server" ID="vDaftarLapKemajuan">
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-12" style="margin-top: 0px; color: #313233e3;">
                    <h4>Monitoring Laporan Kemajuan</h4>
                </div>
                <div class="col-md-8">
                    Skema:       
                    <asp:Label Font-Bold="true" ID="lblNamaSkemaDaftarLapKemajuan" runat="server"></asp:Label><br />
                    Tahun Pendanaan:        
                    <asp:Label runat="server" ID="lblThnPelaksanaanDaftarLapKemajuan" Text="" Font-Bold="true"></asp:Label>
                </div>
                <div class="col-md-4 text-right">
                    <asp:LinkButton ID="lbKembaliDaftarLapKemajuan" runat="server" CssClass="btn btn-info"
                        OnClick="lbKembaliDaftarLapKemajuan_Click">Kembali</asp:LinkButton>
                </div>
                <div class="col-md-12 mt-3 table-responsive">
                    <asp:RadioButtonList ID="rblStsPelaksanaan" runat="server" RepeatDirection="Horizontal"
                        CssClass="radio-button-list" AutoPostBack="true"
                        OnSelectedIndexChanged="rblStsPelaksanaan_SelectedIndexChanged">
                        <asp:ListItem Text="Semua" Value="" Selected="True" />
                        <asp:ListItem Text="Sudah unggah" Value="1" />
                        <asp:ListItem Text="Belum unggah" Value="0" />
                    </asp:RadioButtonList>
                </div>
                <div class="col-md-12 mt-3">
                    <div class="row">
                        <div class="col-md-7">
                            <div class="form-group">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">Jml. Judul :&nbsp;
                                            <asp:Label ID="lblJmlJudulPenetapan" runat="server" Font-Bold="false" Text=""></asp:Label>
                                            &nbsp;&nbsp;<b>|</b>&nbsp;&nbsp;Cari</span>
                                    </div>
                                    <asp:TextBox runat="server" ID="tbPencarianDaftarLapKemajuan" CssClass="form-control" placeholder="Nama Peneliti"></asp:TextBox>
                                    <div class="input-group-append">
                                        <asp:LinkButton runat="server" ID="lbPencarianDaftarLapKemajuan" CssClass="btn btn-outline-info"
                                            OnClick="lbPencarianDaftarLapKemajuan_Click"><i class="fas fa-search"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5">
                            <div class="form-inline" style="color: #7cab3f; float: right">
                                Jml. Baris:&nbsp;        
                                <label for="ddlJmlBarisDaftarLapKemajuan"></label>
                                <asp:DropDownList ID="ddlJmlBarisDaftarLapKemajuan"
                                    OnSelectedIndexChanged="ddlJmlBarisDaftarLapKemajuan_SelectedIndexChanged" runat="server" AutoPostBack="True"
                                    CssClass="form-control input-sm">
                                    <asp:ListItem Text="10" Value="10" Selected="True" />
                                    <asp:ListItem Text="50" Value="50" />
                                    <asp:ListItem Text="100" Value="100" />
                                    <asp:ListItem Text="Semua" Value="0" />
                                </asp:DropDownList>
                                &nbsp;&nbsp;
                                <asp:LinkButton runat="server" ID="lbExcelDaftarLapKemajuan"
                                    ToolTip="Export Excel" ForeColor="Green" OnClick="lbExcelDaftarLapKemajuan_Click">        
                                    <i class="far fa-file-excel fa-2x"></i>
                                </asp:LinkButton>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="table-responsive">
                                <table class="table table-hover table-striped mb-4">
                                    <thead>
                                        <tr>
                                            <th class="text-center" style="width: 40px"><b>No.</b></th>
                                            <th><b>Usulan</b></th>
                                            <th><b>Dokumen</b></th>
                                            <th><b>Status</b></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:ListView ID="lvDaftarLapKemajuan" runat="server"
                                            DataKeyNames="id_usulan_kegiatan, id_transaksi_kegiatan, kd_sts_pelaksanaan"
                                            OnItemDataBound="lvDaftarLapKemajuan_ItemDataBound"
                                            OnItemCommand="lvDaftarLapKemajuan_ItemCommand" >
                                            <ItemTemplate>
                                                <tr>
                                                    <td class="text-center">
                                                        <asp:Label ID="lblNoPenetapan" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblNidn" runat="server" Text='<%# Eval("nidn")%>'></asp:Label>
                                                        - <b>
                                                            <asp:Label ID="lblNama" runat="server" Text='<%# Eval("nama")%>'></asp:Label>
                                                        </b>
                                                        <br />
                                                        <span style="font-style: italic; color: darkblue;">
                                                            <asp:Label ID="lblJudul" runat="server" Text='<%# Eval("judul") %>'></asp:Label>
                                                        </span>
                                                        <br />
                                                        <asp:Label ID="lblTahunKe" runat="server" Text='<%# Eval("tahun_ke")%>'></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton runat="server" ID="lbUnduhLaporanKemajuan" CommandName="unduhLaporanKemajuan"
                                                            CssClass="far fa-file-pdf" ForeColor="Gray" Font-Size="30px" Font-Bold="true"
                                                            CommandArgument="<%# Container.DataItemIndex %>"
                                                            Visible='<%# (Eval("kd_sts_pelaksanaan").ToString() == "1") ? true : false %>'>
                                                        </asp:LinkButton>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblStsPenetepan" runat="server" Font-Size="Medium" Text='<%# Eval("sts_pelaksanaan")%>'
                                                            CssClass='<%# (Eval("kd_sts_pelaksanaan").ToString() == "1") ? 
                                                            "badge badge-success" : "badge badge-danger" %>'></asp:Label>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <EmptyDataTemplate>
                                                <tr>
                                                    <td colspan="5" style="text-align: center" class="alert alert-info text-center" role="alert">
                                                        <h5>DATA TIDAK DITEMUKAN</h5>
                                                    </td>
                                                </tr>
                                            </EmptyDataTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                            <asc:controlPaging runat="server" ID="pagingDaftarLapKemajuan" OnPageChanging="pagingDaftarLapKemajuan_PageChanging" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:View>
</asp:MultiView>
<uc:ktPdfLaporanKemajuanKontrol runat="server" ID="ktPdfLaporanKemajuanKontrol" Visible="false" />