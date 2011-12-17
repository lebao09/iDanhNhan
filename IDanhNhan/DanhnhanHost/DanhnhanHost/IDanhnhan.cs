using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Data;
using System.Data.SqlClient;

namespace DanhnhanHost
{
    [ServiceContract]
    public interface IDanhnhan
    {
        [OperationContract]
        String GetAuthors();
        [OperationContract]
        String Detai();
        [OperationContract]
        DataSet ShowAll();
        [OperationContract]
        DataSet ShowImage();
        [OperationContract]
        void ExcuteNoneQuery(String query);
        [OperationContract]
        DataSet GetTable(String query);

        [OperationContract]
        String GetTenDanhMuc(String condition);
        [OperationContract]
        String GetTen(String condition);
        [OperationContract]
        String GetDanhHieu(String condition);
        [OperationContract]
        String GetNienHieu(String condition);
        [OperationContract]
        String GetNgaySinh(String condition);
        [OperationContract]
        String GetNgayMat(String condition);
        [OperationContract]
        String GetNoiSinh(String condition);
        [OperationContract]
        String GetTaiNang(String condition);
        [OperationContract]
        String GetSuNghiep(String condition);
        [OperationContract]
        String GetThanhTuu(String condition);
        [OperationContract]
        String GetHoatDong(String condition);
        [OperationContract]
        String GetGiaiThuong(String condition);
        [OperationContract]
        String GetPathHinhanh(String condition);
    }
}
