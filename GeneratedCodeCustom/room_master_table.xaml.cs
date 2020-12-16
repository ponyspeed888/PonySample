


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
    public partial class EFGridViewroom_master_table : EFGridViewBase<moviesContext>
    {

        //public DbContext _ctx;

        //public override DbContext ctx { get { return _ctx; }  set { _ctx = value; } }

        List<Picker> pickers = new List<Picker>();
        

        public EFGridViewroom_master_table()
        {
            InitializeComponent();

            ctx = new moviesContext();


            


            
            GridTextColumn colid = new GridTextColumn();
            colid.MappingName = "id";
            dataGrid.Columns.Add(colid);


            GridTextColumn colidentity_hash = new GridTextColumn();
            colidentity_hash.MappingName = "identity_hash";
            dataGrid.Columns.Add(colidentity_hash);



 

            GetQuery ();
        }


   

   
        public void GetQuery ()
        //public IQueryable<room_master_table> GetQuery ()
        {
            var q = ctx.Set<room_master_table>().AsQueryable<room_master_table>();
            
            


            dataGrid.ItemsSource = q.ToList () ;

  
        }


    

    }
}





