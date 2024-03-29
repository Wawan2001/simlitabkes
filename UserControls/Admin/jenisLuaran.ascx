﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="jenisLuaran.ascx.cs" Inherits="simlitekkes.UserControls.Admin.jenisLuaran" %>
<%@ Register Src="~/Helper/controlPaging.ascx" TagName="controlPaging" TagPrefix="asp" %>
<div class="row">
    <div class="col-md-8">
        <div class="card">
            <div class="card-header bg-info text-white">
                <h6>Daftar Jenis Luaran</h6>
            </div>
            <div class="card-body row">
                <div class="col-md-4">
                    <div class="form-group">
                        <label for="ddlJmlBarisJenisLuaran">Jml Baris:</label>
                        <asp:DropDownList ID="ddlJmlBarisJenisLuaran" runat="server" AutoPostBack="True"
                            CssClass="form-control input-sm" OnSelectedIndexChanged="ddlJmlBarisJenisLuaran_SelectedIndexChanged">
                            <asp:ListItem Text="10" Value="10" Selected="True" />
                            <asp:ListItem Text="2" Value="2" />
                            <asp:ListItem Text="50" Value="50" />
                            <asp:ListItem Text="100" Value="100" />
                            <asp:ListItem Text="Semua" Value="0" />
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form-group">
                        <label for="ddlKategoriJenisLuaran">Kategori Jenis Luaran</label>
                        <asp:DropDownList ID="ddlKategoriJenisLuaran" runat="server" AutoPostBack="True"
                            CssClass="form-control input-sm" OnSelectedIndexChanged="ddlKategoriJenisLuaran_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-12">
                    <div class="table-responsive">
                        <asp:GridView ID="gvDaftarJenisLuaran" runat="server" GridLines="None"
                            CssClass="table table-striped table-hover"
                            DataKeyNames="id_jenis_luaran, kd_kategori_jenis_luaran, nama_kategori_jenis_luaran, nama_jenis_luaran, kd_sts_aktif_jenis_luaran"
                            ShowHeader="true" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False"
                            OnRowDataBound="gvDaftarJenisLuaran_RowDataBound"
                            OnRowDeleting="gvDaftarJenisLuaran_RowDeleting"
                            OnRowEditing="gvDaftarJenisLuaran_RowEditing"
                            OnRowCancelingEdit="gvDaftarJenisLuaran_RowCancelEditing"
                            OnRowUpdating="gvDaftarJenisLuaran_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="No." HeaderStyle-Width="5%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNoDaftarJenisLuaran" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Font-Bold="true" CssClass="ext-center" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Kategori Jenis Luaran" HeaderStyle-Width="35%">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblKategoriJenisLuaran" Text='<%# Bind("nama_kategori_jenis_luaran") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:DropDownList runat="server" ID="ddlKdKategoriJenisLuaranEdit" CssClass="form-control"></asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nama Jenis Luaran" HeaderStyle-Width="30%">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNamaJenisLuaran" runat="server" Text='<%# Bind("nama_jenis_luaran") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox runat="server" ID="tbNamaJenisLuaranEdit" CssClass="form-control" placeholder="Nama Jenis Luaran" Text='<%# Bind("nama_jenis_luaran") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderStyle-Width="30%">
                                    <HeaderTemplate>
                                        <i class="fas fa-th"></i>
                                    </HeaderTemplate>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" CssClass="text-center" />
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbHapusDaftarJenisLuaran" runat="server" CommandName="Delete"
                                            CssClass="btn btn-danger mr-2" ToolTip="Hapus Jenis Luaran">
                                        <i class="fas fa-trash"></i>
                                        </asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbEditDaftarJenisLuaran" CssClass="btn btn-primary" CommandName="Edit" ToolTip="Edit Jenis Luaran">
                                        <i class="fas fa-edit"></i>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:LinkButton ID="lbUpdate" runat="server" CommandName="Update"
                                            CssClass="btn btn-success mr-2" ToolTip="Update Jenis Luaran">
                                        <i class="fas fa-save"></i>
                                        </asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbCancelUpdate" CssClass="btn btn-danger" CommandName="Cancel" ToolTip="Batal Edit Jenis Luaran">
                                        <i class="fas fa-undo"></i>
                                        </asp:LinkButton>
                                    </EditItemTemplate>
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
            <div class="card-footer">
                <asp:controlPaging runat="server" ID="pagingDaftarJenisLuaran" OnPageChanging="daftarJenisLuaran_PageChanging" />
            </div>
        </div>
    </div>
    <div class="col-md-4">
        <div class="card">
            <div class="card-header bg-primary text-white">
                <h6>Tambah Jenis Luaran</h6>
            </div>
            <div class="card-body row">
                <div class="col-md-12">
                    <div class="form-group">
                        <label>Kategori Jenis Luaran</label>
                        <asp:DropDownList runat="server" ID="ddlKategoriJenisLuaranAdd" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-12">
                    <div class="form-group">
                        <label>Nama Jenis Luaran</label>
                        <asp:TextBox runat="server" ID="tbNamaJenisLuaranAdd" CssClass="form-control" placeholder="Nama Jenis Luaran"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="card-footer">
                <div class="float-right">
                    <asp:LinkButton runat="server" ID="lbBatal" CssClass="btn btn-danger mr-2" OnClick="lbBatal_Click">
                    <i class="fas fa-undo mr-2"></i>Batal
                    </asp:LinkButton>
                    <asp:LinkButton runat="server" ID="lbSimpanJenisLuaran" CssClass="btn btn-success" OnClick="lbSimpanJenisLuaran_Click">
                    <i class="fas fa-save mr-2"></i>Simpan
                    </asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="modal modal-primary" id="modalHapus" role="dialog" aria-labelledby="myModalHapus">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title font-weight-600" id="dangerModalLabel">Konfirmasi Hapus Jenis Luaran</h5>
                <button type="button" class="close text-white" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">×</span>
                </button>
            </div>
            <div class="modal-body">
                Apakah yakin akan menghapus Jenis Luaran
                &nbsp;<asp:Label runat="server" ID="lblJenisLuaran" Text=""></asp:Label>&nbsp;?
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-primary" data-dismiss="modal">Batal</button>
                <asp:LinkButton ID="lbHapusJenisLuaran" runat="server" CssClass="btn btn-danger float-rigth" OnClick="lbHapusJenisLuaran_Click" OnClientClick="$('#modalHapus').modal('hide');">Hapus</asp:LinkButton>
            </div>
        </div>
    </div>
</div>
