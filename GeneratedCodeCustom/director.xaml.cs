


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
    public partial class EFGridViewdirector : EFGridViewBase<moviesContext>
    {

        //public DbContext _ctx;

        //public override DbContext ctx { get { return _ctx; }  set { _ctx = value; } }

        List<Picker> pickers = new List<Picker>();
        

        public EFGridViewdirector()
        {
            InitializeComponent();

            ctx = new moviesContext();


            


            
            GridTextColumn coldid = new GridTextColumn();
            coldid.MappingName = "did";
            dataGrid.Columns.Add(coldid);


            GridTextColumn colfull_name = new GridTextColumn();
            colfull_name.MappingName = "full_name";
            dataGrid.Columns.Add(colfull_name);



 

            GetQuery ();
        }


   

   
        public void GetQuery ()
        //public IQueryable<director> GetQuery ()
        {
            var q = ctx.Set<director>().AsQueryable<director>();
            
            


            dataGrid.ItemsSource = q.ToList () ;

  
        }


    

    }
}





