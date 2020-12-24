using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service3B_102
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "Mahasiswa", ResponseFormat = WebMessageFormat.Json)]
        string UpdateMahasiswa(string nim, string nama, string prodi, string angkatan);

        [OperationContract]
        [WebGet(UriTemplate = "Mahasiswa/nim={nim}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteByNIM(string nim);

        [OperationContract]
        [WebGet(UriTemplate = "Mahasiswa", ResponseFormat = WebMessageFormat.Json)]
        string CountMahasiswa();
    }
}
