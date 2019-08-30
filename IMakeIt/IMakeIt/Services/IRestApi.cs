using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace IMakeIt.Services
{
    public interface IRestApi
    {











        //[Headers("Authorization: Bearer", "Authorization: Basic")]
        //[Get("/token/43")]
        //Task<EndPointResponse> GetToken();

        //[Headers("cpf:", "cnpj:")]
        //[Get("/token-entrega")]
        //Task<EndPointResponse> GetTokenRomaneio([Header("cpf")] string cpf, [Header("cnpj")] string cnpj);



        //[Headers("Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpZCI6IjUzIiwiYW1iaWVudGUiOiI0MyIsImV4cGlyYV9lbSI6IjIwMTktMDEtMjMgMDk6NDE6NDQiLCJncnVwb3MiOlsiMiJdfQ.p69vMnjGrXsyrRhbz5rtnLUoe7xjFGR5pO-OfNvOVxY ",
        //    "cpf:17919183871",
        ////    "senha:admin01")]
        //[Headers("cpf:", "senha:")]
        //[Get("/motorista/autenticar")]
        //Task<RootMotorist> GetMotorista([Header("cpf")] string user, [Header("senha")] string password);

        //[Post("/romaneios/solicitar")]
        //Task<RootRomaneio> GetRomaneios([Body] object request);

        //[Post("/romaneios/{IdRomaneio}/iniciar")]
        //Task<EndPointResponse> StartRomaneio(string IdRomaneio, StartRomaneioModel data);



        //[Post("/entregas/{IdEntrega}/cancelar")]
        //Task<EndPointResponse> SuspendDelivery(string IdEntrega, Dictionary<string, string> data);

        //[Post("/entregas/iniciar?")]
        //Task<EndPointResponse> StartDelivery(Dictionary<string, object> data);


        //[Post("/entregas/{IdEntrega}/finalizar")]
        //Task<EndPointResponse> FinishDeliveryApi(string IdEntrega, [Body]  FinishDeliveryModel resposta);


        //[Post("/entregas/{IdEntrega}/cancelar")]
        //Task<EndPointResponse> CancelDelivery(string IdEntrega, [Body] CancelDeliveryModel resposta);


        ////[Post("/volumes/{TypeVolume}")]
        ////Task<EndPointResponse> VolumeUnloading(string TypeVolume, [Body] VolumeUnloadingModel resposta);

        //[Post("/volumes/{TypeVolume}")]
        //Task<EndPointResponse> VolumeUnloading(string TypeVolume, [Body] string resposta);

        //[Post("/motorista/{idMotorista}/atualizar")]
        //Task<EndPointResponse> EnableAndDisableMotorist(string idMotorista, [Body] Dictionary<string, object> data);

        //Task<EndPointResponse> VolumeUnloading(string typeVolume, List<VolumeUnloadingModel> listDevolvido);


        //[Get("/entregas?romaneio={CodigoRomaneio}&app=true")]
        //Task<RootEntrega> GetEntregas(string CodigoRomaneio);

        //[Get("/romaneios/{romaneioId}/iniciar")]
        //Task<HttpResponseMessage> StartRomaneio(string romaneioId);

        //[Post("/entregas/iniciar")]
        //Task<EndPointResponse> StartEntrega([Body] IniciarEntrega resposta);


        //[Post("/entregas/{entregaId}/finalizar")]
        //Task FinalizarEntregaConcluida(string entregaId, [Body]  EntregaFinalizadaResponse resposta);



    }
}
