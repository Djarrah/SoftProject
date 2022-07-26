using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GestioneFatture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // populate dropdown list
        if (!IsPostBack)
        {
            UpdateDdlAnno();
            UpdateCommesse();
            
        }
        
    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        FATTURE f = new FATTURE();
        DataTable dt = new DataTable();

        int anno = int.Parse(ddlAnno.SelectedValue);
        

        int mese = int.Parse(ddlMese.SelectedValue);
        

        int commesse = int.Parse(ddlCommessa.SelectedValue);
        dt= f.SelectCommesse(anno, mese);

        f.CodiceCommessa= commesse;
        decimal sommaCorpo = (decimal)f.ImportoTotale();
        decimal sommaOre= (decimal)f.ImportoTotaleOre();
        decimal sommaLavori= (decimal)f.SommaLavori(anno, mese);

        lblImportoTotale.Text= $"{sommaCorpo}";
        lblImpOre.Text= $"{sommaOre}";
        lblSomLav.Text= $"{sommaLavori}";


        aggiornaGriglia();

    }
    public void UpdateDdlAnno()
    {
        for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 2; i--)
        {
            ddlAnno.Items.Add(i.ToString());
        }
    }
    public void UpdateCommesse()
    {
        FATTURE f = new FATTURE();

        ddlCommessa.DataSource = f.SelectCommesse(int.Parse(ddlAnno.SelectedValue), int.Parse(ddlMese.SelectedValue));
        ddlCommessa.DataTextField = "Descrizione Commessa";
        ddlCommessa.DataValueField="CodiceCommessa";
        ddlCommessa.DataBind();

    }


    protected void ddlAnno_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateCommesse();
    }

    protected void ddlMese_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateCommesse();
    }

    public void aggiornaGriglia()
    {
        FATTURE f = new FATTURE();
        griglia.DataSource= f.Select(int.Parse(ddlAnno.SelectedValue), int.Parse(ddlMese.SelectedValue));
        griglia.DataBind();
    }

   
}

