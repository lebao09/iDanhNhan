﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DanhnhanClient.DanhNhanSH {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DanhNhanSH.IDanhnhan")]
    public interface IDanhnhan {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetAuthors", ReplyAction="http://tempuri.org/IDanhnhan/GetAuthorsResponse")]
        string GetAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/Detai", ReplyAction="http://tempuri.org/IDanhnhan/DetaiResponse")]
        string Detai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/ShowAll", ReplyAction="http://tempuri.org/IDanhnhan/ShowAllResponse")]
        System.Data.DataSet ShowAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/ShowImage", ReplyAction="http://tempuri.org/IDanhnhan/ShowImageResponse")]
        System.Data.DataSet ShowImage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/ExcuteNoneQuery", ReplyAction="http://tempuri.org/IDanhnhan/ExcuteNoneQueryResponse")]
        void ExcuteNoneQuery(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetTable", ReplyAction="http://tempuri.org/IDanhnhan/GetTableResponse")]
        System.Data.DataSet GetTable(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetTenDanhMuc", ReplyAction="http://tempuri.org/IDanhnhan/GetTenDanhMucResponse")]
        string GetTenDanhMuc(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetTen", ReplyAction="http://tempuri.org/IDanhnhan/GetTenResponse")]
        string GetTen(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetDanhHieu", ReplyAction="http://tempuri.org/IDanhnhan/GetDanhHieuResponse")]
        string GetDanhHieu(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetNienHieu", ReplyAction="http://tempuri.org/IDanhnhan/GetNienHieuResponse")]
        string GetNienHieu(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetNgaySinh", ReplyAction="http://tempuri.org/IDanhnhan/GetNgaySinhResponse")]
        string GetNgaySinh(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetNgayMat", ReplyAction="http://tempuri.org/IDanhnhan/GetNgayMatResponse")]
        string GetNgayMat(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetNoiSinh", ReplyAction="http://tempuri.org/IDanhnhan/GetNoiSinhResponse")]
        string GetNoiSinh(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetTaiNang", ReplyAction="http://tempuri.org/IDanhnhan/GetTaiNangResponse")]
        string GetTaiNang(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetSuNghiep", ReplyAction="http://tempuri.org/IDanhnhan/GetSuNghiepResponse")]
        string GetSuNghiep(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetThanhTuu", ReplyAction="http://tempuri.org/IDanhnhan/GetThanhTuuResponse")]
        string GetThanhTuu(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetHoatDong", ReplyAction="http://tempuri.org/IDanhnhan/GetHoatDongResponse")]
        string GetHoatDong(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetGiaiThuong", ReplyAction="http://tempuri.org/IDanhnhan/GetGiaiThuongResponse")]
        string GetGiaiThuong(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDanhnhan/GetPathHinhanh", ReplyAction="http://tempuri.org/IDanhnhan/GetPathHinhanhResponse")]
        string GetPathHinhanh(string condition);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDanhnhanChannel : DanhNhanSH.IDanhnhan, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DanhnhanClient : System.ServiceModel.ClientBase<DanhNhanSH.IDanhnhan>, DanhNhanSH.IDanhnhan {
        
        public DanhnhanClient() {
        }
        
        public DanhnhanClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DanhnhanClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DanhnhanClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DanhnhanClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAuthors() {
            return base.Channel.GetAuthors();
        }
        
        public string Detai() {
            return base.Channel.Detai();
        }
        
        public System.Data.DataSet ShowAll() {
            return base.Channel.ShowAll();
        }
        
        public System.Data.DataSet ShowImage() {
            return base.Channel.ShowImage();
        }
        
        public void ExcuteNoneQuery(string query) {
            base.Channel.ExcuteNoneQuery(query);
        }
        
        public System.Data.DataSet GetTable(string query) {
            return base.Channel.GetTable(query);
        }
        
        public string GetTenDanhMuc(string condition) {
            return base.Channel.GetTenDanhMuc(condition);
        }
        
        public string GetTen(string condition) {
            return base.Channel.GetTen(condition);
        }
        
        public string GetDanhHieu(string condition) {
            return base.Channel.GetDanhHieu(condition);
        }
        
        public string GetNienHieu(string condition) {
            return base.Channel.GetNienHieu(condition);
        }
        
        public string GetNgaySinh(string condition) {
            return base.Channel.GetNgaySinh(condition);
        }
        
        public string GetNgayMat(string condition) {
            return base.Channel.GetNgayMat(condition);
        }
        
        public string GetNoiSinh(string condition) {
            return base.Channel.GetNoiSinh(condition);
        }
        
        public string GetTaiNang(string condition) {
            return base.Channel.GetTaiNang(condition);
        }
        
        public string GetSuNghiep(string condition) {
            return base.Channel.GetSuNghiep(condition);
        }
        
        public string GetThanhTuu(string condition) {
            return base.Channel.GetThanhTuu(condition);
        }
        
        public string GetHoatDong(string condition) {
            return base.Channel.GetHoatDong(condition);
        }
        
        public string GetGiaiThuong(string condition) {
            return base.Channel.GetGiaiThuong(condition);
        }
        
        public string GetPathHinhanh(string condition) {
            return base.Channel.GetPathHinhanh(condition);
        }
    }
}
