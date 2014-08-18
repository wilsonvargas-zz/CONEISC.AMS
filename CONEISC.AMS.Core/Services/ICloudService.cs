using System;
namespace CONEISC.AMS.Core.Services
{
    public interface ICloudService
    {
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<CONEISC.AMS.Core.Models.Contacto>> GetAll();
        System.Threading.Tasks.Task SaveAll(System.Collections.ObjectModel.ObservableCollection<CONEISC.AMS.Core.Models.Contacto> entidades);
    }
}
