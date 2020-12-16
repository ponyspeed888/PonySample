


using Microsoft.EntityFrameworkCore;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonySample.GeneratedCodeCustom;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NutrientDb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EFGridViewandroid_metadatum : EFGridViewBase<moviesContext>
    {

        //public DbContext _ctx;

        //public override DbContext ctx { get { return _ctx; }  set { _ctx = value; } }

        List<Picker> pickers = new List<Picker>();
        

        public EFGridViewandroid_metadatum()
        {
            InitializeComponent();

            ctx = new moviesContext();


            


            
            GridTextColumn collocale = new GridTextColumn();
            collocale.MappingName = "locale";
            dataGrid.Columns.Add(collocale);



 

            GetQuery ();
        }


   

   
        public void GetQuery ()
        //public IQueryable<android_metadatum> GetQuery ()
        {
            var q = ctx.Set<android_metadatum>().AsQueryable<android_metadatum>();
            
            


            dataGrid.ItemsSource = q.ToList () ;

  
        }


    

    }
}





