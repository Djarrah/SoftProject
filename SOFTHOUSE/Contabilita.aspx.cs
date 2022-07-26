using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int annoCorrente = DateTime.Now.Year;
            for (int i = annoCorrente; i >= annoCorrente - 2; i--)
            {
                ddlAnno.Items.Add(i.ToString());
            }
        }
        
    }

    protected void btnCalcola_Click(object sender, EventArgs e)
    {
        int anno = int.Parse(ddlAnno.SelectedValue);
        int mese = int.Parse(ddlMese.SelectedValue);
        
        if (int.Parse(ddlMese.SelectedValue) == 0)
        {
            lblFatturato.Text = CONTABILITA.SommaFatture(anno).ToString();
            lblSpeseLavoratori.Text = CONTABILITA.SommaStipendi(anno).ToString();
            lblSpeseVarie.Text = CONTABILITA.SommaSpese(anno).ToString();
            lblRicavi.Text = CONTABILITA.Ricavo(anno).ToString();
        }
        else
        {
            lblFatturato.Text = CONTABILITA.SommaFatture(anno, mese).ToString();
            lblSpeseLavoratori.Text = CONTABILITA.SommaStipendi(anno, mese).ToString();
            lblSpeseVarie.Text = CONTABILITA.SommaSpese(anno, mese).ToString();
            lblRicavi.Text = CONTABILITA.Ricavo(anno, mese).ToString();
        }
    }
}