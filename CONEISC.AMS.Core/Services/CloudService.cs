using CONEISC.AMS.Core.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEISC.AMS.Core.Services
{
    public class CloudService : CONEISC.AMS.Core.Services.ICloudService
    {
        //Agregar aquí el enlace de tu servicio móvil en Azure y tu código de acceso
        private readonly MobileServiceClient MobileService = new MobileServiceClient("", "");

        public async Task<ObservableCollection<Contacto>> GetAll()
        {

            ObservableCollection<Contacto> coleccion = new ObservableCollection<Contacto>();

            try
            {
                var tabla = MobileService.GetTable<Contacto>();
                coleccion = await tabla.ToCollectionAsync<Contacto>();
                Debug.WriteLine("ENTRE A RECIBIR LA DATA");
            }
            catch (Exception ex)
            {
                ReportarError(ex);
            }

            return coleccion;

        }

        public async Task SaveAll(ObservableCollection<Contacto> entidades)
        {
            if (entidades != null && entidades.Count > 0)
            {
                try
                {
                    var tabla = MobileService.GetTable<Contacto>();

                    foreach (Contacto item in entidades)
                    {
                        await tabla.InsertAsync(item);
                    }
                }
                catch (Exception ex)
                {

                    ReportarError(ex);
                }
            }

        }


        private void ReportarError(Exception ex)
        {
            throw new NotImplementedException();
        }

    }
}
