using Cirrious.MvvmCross.ViewModels;
using CONEISC.AMS.Core.Models;
using CONEISC.AMS.Core.Services;
using System.Collections.ObjectModel;

namespace CONEISC.AMS.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {

        private readonly ICloudService _cloudService;

        public FirstViewModel(ICloudService pCloudService)
        {
            _cloudService = pCloudService;
        }

        private ObservableCollection<Contacto> _contactos;

        public ObservableCollection<Contacto> Contactos
        {
            get { return _contactos; }
            set
            {
                if (_contactos != value)
                {
                    _contactos = value;
                    RaisePropertyChanged(() => Contactos);
                }
            }
        }

        public void LlenarContactos()
        {
            ObservableCollection<Contacto> nuevosContactos = new ObservableCollection<Contacto>();

            nuevosContactos.Add(new Contacto() { Nombre = "George", Apellido = "Washington", Correo = "George@fake.com", NumeroTelefono = "02 555 1111", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/X/9/washington.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "John", Apellido = "Adams", Correo = "John@fake.com", NumeroTelefono = "02 555 1112", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/a/9/2_adams.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Thomas", Apellido = "Jefferson", Correo = "Thomas@fake.com", NumeroTelefono = "02 555 1113", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/Z/9/t_jefferson.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "James", Apellido = "Madison", Correo = "James@fake.com", NumeroTelefono = "02 555 1114", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/b/9/4_madison.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "James", Apellido = "Monroe", Correo = "James@fake.com", NumeroTelefono = "02 555 1115", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/c/9/5_monroe.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "John Quincy", Apellido = "Adams", Correo = "John@fake.com", NumeroTelefono = "02 555 1116", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/d/9/6_john_q_adams_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Andrew", Apellido = "Jackson", Correo = "Andrew@fake.com", NumeroTelefono = "02 555 1117", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/V/9/Andrew_jackson_head.gif" });
            nuevosContactos.Add(new Contacto() { Nombre = "Martin", Apellido = "van Buren", Correo = "Martin@fake.com", NumeroTelefono = "02 555 1118", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/e/9/8_van_buren_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "William Henry", Apellido = "Harrison", Correo = "William@fake.com", NumeroTelefono = "02 555 1119", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/f/9/9_william_harrison.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "John", Apellido = "Tyler", Correo = "John@fake.com", NumeroTelefono = "02 555 1120", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/g/9/10_john_tyler_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "James K.", Apellido = "Polk", Correo = "James@fake.com", NumeroTelefono = "02 555 1121", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/7/2/polk2.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Zachary", Apellido = "Taylor", Correo = "Zachary@fake.com", NumeroTelefono = "02 555 1122", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/h/9/12_z_taylor_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Millard", Apellido = "Filmore", Correo = "Millard@fake.com", NumeroTelefono = "02 555 1123", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/i/9/13_fillmore_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Franklin", Apellido = "Pierce", Correo = "Franklin@fake.com", NumeroTelefono = "02 555 1124", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/j/9/14_pierce_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "James", Apellido = "Buchanan", Correo = "James@fake.com", NumeroTelefono = "02 555 1125", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/k/9/15_buchanan_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Abraham", Apellido = "Lincoln", Correo = "Abraham@fake.com", NumeroTelefono = "02 555 1126", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/l/9/16_lincoln_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Andrew", Apellido = "Johnson", Correo = "Andrew@fake.com", NumeroTelefono = "02 555 1127", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/6/2/andrewjohnson1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Ulysees S.", Apellido = "Grant", Correo = "Ulysees@fake.com", NumeroTelefono = "02 555 1128", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/m/9/18_grant_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Rutherford B.", Apellido = "Hayes", Correo = "Rutherford@fake.com", NumeroTelefono = "02 555 1129", ImageUrl = "http://americanhistory.about.com/od/uspresidents/ig/Images-of-US-Presidents/Rutherford-B-Hayes.htm" });
            nuevosContactos.Add(new Contacto() { Nombre = "James A.", Apellido = "Garield", Correo = "James@fake.com", NumeroTelefono = "02 555 1130", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/o/9/20_garfield_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Chester A.", Apellido = "Arthur", Correo = "Chester@fake.com", NumeroTelefono = "02 555 1131", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/p/9/21_arthur_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Grover", Apellido = "Cleveland", Correo = "Grover@fake.com", NumeroTelefono = "02 555 1132", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/q/9/22_cleveland_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Benjamin", Apellido = "Harrison", Correo = "Benjamin@fake.com", NumeroTelefono = "02 555 1133", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/r/9/23_b_harrison_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Grover", Apellido = "Cleveland", Correo = "Grover@fake.com", NumeroTelefono = "02 555 1134", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/q/9/22_cleveland_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "William", Apellido = "McKinley", Correo = "William@fake.com", NumeroTelefono = "02 555 1135", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/s/9/25_w_mckinley.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Theodore", Apellido = "Roosevelt", Correo = "Theodore@fake.com", NumeroTelefono = "02 555 1136", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/t/9/26_t_roosevelt_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "William Howard", Apellido = "Taft", Correo = "William@fake.com", NumeroTelefono = "02 555 1137", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/u/9/27_taft_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Woodrow", Apellido = "Wilson", Correo = "Woodrow@fake.com", NumeroTelefono = "02 555 1138", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/8/2/wilson2.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Warren G.", Apellido = "Harding", Correo = "Warren@fake.com", NumeroTelefono = "02 555 1139", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/v/9/29_harding_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Calvin", Apellido = "Coolidge", Correo = "Calvin@fake.com", NumeroTelefono = "02 555 1140", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/w/9/30_coolidge_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Herbert", Apellido = "Hoover", Correo = "Herbert@fake.com", NumeroTelefono = "02 555 1141", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/8/A/31_hoover_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Franklin D.", Apellido = "Roosevelt", Correo = "Franklin@fake.com", NumeroTelefono = "02 555 1142", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/x/9/32_fdr_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Calvin", Apellido = "Coolidge", Correo = "Calvin@fake.com", NumeroTelefono = "02 555 1143", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/y/9/33_truman_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Harry S.", Apellido = "Truman", Correo = "Harry@fake.com", NumeroTelefono = "02 555 1144", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/z/9/34_eisenhower_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Dwight D.", Apellido = "Eisenhower", Correo = "Dwight@fake.com", NumeroTelefono = "02 555 1145", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/-/A/35_jfk_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "John F.", Apellido = "Kennedy", Correo = "John@fake.com", NumeroTelefono = "02 555 1146", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/0/A/36_lbj_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Lyndon B.", Apellido = "Johnson", Correo = "Lyndon@fake.com", NumeroTelefono = "02 555 1147", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/0/A/36_lbj_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Richard", Apellido = "Nixon", Correo = "Richard@fake.com", NumeroTelefono = "02 555 1148", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/1/A/37_nixon_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Gerald", Apellido = "Ford", Correo = "Gerald@fake.com", NumeroTelefono = "02 555 1149", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/2/A/38_ford_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Jimmy", Apellido = "Carter", Correo = "Jimmy@fake.com", NumeroTelefono = "02 555 1150", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/3/A/39_carter_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Ronald", Apellido = "Reagan", Correo = "Ronald@fake.com", NumeroTelefono = "02 555 1151", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/4/A/40_reagan.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "George H.W.", Apellido = "Bush", Correo = "George@fake.com", NumeroTelefono = "02 555 1152", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/5/A/41-georgebush_1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Bill", Apellido = "Clinton", Correo = "Bill@fake.com", NumeroTelefono = "02 555 1153", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/6/A/42_clinton-1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "George W.", Apellido = "Bush", Correo = "George@fake.com", NumeroTelefono = "02 555 1154", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/7/A/43_georgewbush-1.jpg" });
            nuevosContactos.Add(new Contacto() { Nombre = "Barack", Apellido = "Obama", Correo = "Barack@fake.com", NumeroTelefono = "02 555 1155", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/I/B/b_obama.jpg" });

            _cloudService.SaveAll(nuevosContactos);
        }


        public async void CargarContactos()
        {
            this.Contactos = await _cloudService.GetAll();

            if (this.Contactos == null || this.Contactos.Count == 0)
            {
                LlenarContactos();
                this.Contactos = await _cloudService.GetAll();
            }
        }



    }
}
