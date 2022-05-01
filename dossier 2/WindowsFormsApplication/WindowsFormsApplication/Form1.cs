using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listeDuClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // liste client :
            FormListeClient flisteClient = new FormListeClient();
            flisteClient.MdiParent = this;
            flisteClient.Show();
        }

        private void listeDuClientType2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // liste client :
            Form2ListeClient f2listeClient = new Form2ListeClient();
            f2listeClient.MdiParent = this;
            f2listeClient.Show();
        }

        private void listeSimpleAvecFiltrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // liste client avec filtrage :
            FormListeClientFiltree flisteClientfiltree = new FormListeClientFiltree();
            flisteClientfiltree.MdiParent = this;
            flisteClientfiltree.Show();
        }

        private void listeDesClientsRegroupesParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // liste client regroupes par ville :
            FormRegroupementClientParVille flisteClientRegroupesParVille = new FormRegroupementClientParVille();
            flisteClientRegroupesParVille.MdiParent = this;
            flisteClientRegroupesParVille.Show();
        }

        private void listeDesClientsRegroupesParMagasinGroupeDeColonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // liste client regroupes par ville :
            FormClientRegroupesParVilleColonnes flisteClientRegroupesParVilleColonnes = new FormClientRegroupesParVilleColonnes();
            flisteClientRegroupesParVilleColonnes.MdiParent = this;
            flisteClientRegroupesParVilleColonnes.Show();
        }

        private void listeDesClientsRegroupesParMagasinGroupeDeColonnesFiltrésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientRegroupesParVilleColonnesFiltree flisteClientRegroupesParVilleColonnesFiltree = new FormClientRegroupesParVilleColonnesFiltree();
            flisteClientRegroupesParVilleColonnesFiltree.MdiParent = this;
            flisteClientRegroupesParVilleColonnesFiltree.Show();
        }

        private void histogrammeNombreDesClientsParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistogrammeNombreClientParVille fhistogrammeNbrClientsParVille = new FormHistogrammeNombreClientParVille();
            fhistogrammeNbrClientsParVille.MdiParent = this;
            fhistogrammeNbrClientsParVille.Show();
        }

        private void secteursNombreDesClientsParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecteursNombreClientParVille fSecteursNbrClientsParVille = new SecteursNombreClientParVille();
            fSecteursNbrClientsParVille.MdiParent = this;
            fSecteursNbrClientsParVille.Show();
        }

        private void modeConnectéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeconnecteClient fClientDeconnecte = new FormDeconnecteClient();
            fClientDeconnecte.MdiParent = this;
            fClientDeconnecte.Show();
        }

        private void modeConnectéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConnecteClient fClientConnecte = new FormConnecteClient();
            fClientConnecte.MdiParent = this;
            fClientConnecte.Show();
        }

        private void deLaBaseDeDonnéesVersUnFichierExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exporter les données de la base de données vers un fichier excel :
            FormExporterFromDataBaseToExcel fDbToExcel = new FormExporterFromDataBaseToExcel();
            fDbToExcel.MdiParent = this;
            fDbToExcel.Show();
        }

        private void deLobjetDataSetVersUnFichierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportDataFromDataSetToXML fDataSetToXML = new FormExportDataFromDataSetToXML();
            fDataSetToXML.MdiParent = this;
            fDataSetToXML.Show();
        }

        private void depuisXMLVersDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImporterDataFromXMLtoDataGridView fimporterFromXMLtoDgview = new FormImporterDataFromXMLtoDataGridView();
            fimporterFromXMLtoDgview.MdiParent = this;
            fimporterFromXMLtoDgview.Show();
        }

        private void deLaTableSqlVersUnFichierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExporterDataFormTableToXml fexporterFromTableToXML = new FormExporterDataFormTableToXml();
            fexporterFromTableToXML.MdiParent = this;
            fexporterFromTableToXML.Show();
        }

        private void deLaTableSqlVersUnFichierHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExporterDataToHtml fexporterDataToHtml = new FormExporterDataToHtml();
            fexporterDataToHtml.MdiParent = this;
            fexporterDataToHtml.Show();
        }

        private void rechercherMulticritéresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRechercherCheque frechercherCheque = new FormRechercherCheque();
            frechercherCheque.MdiParent = this;
            frechercherCheque.Show();
        }

        private void miseÀJourAvecDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGridClient fMajGridClient = new FormGridClient();
            fMajGridClient.MdiParent = this;
            fMajGridClient.Show();
        }

        private void deLaBaseVersUnXMLAvecSaveFileDialogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportDataFromDataTableToXML fExporterVersXMLavecSaveFileDialog = new FormExportDataFromDataTableToXML();
            fExporterVersXMLavecSaveFileDialog.MdiParent = this;
            fExporterVersXMLavecSaveFileDialog.Show();
        }

        private void depuisUnFichierXMLVersDataGridViewFichierChoisiParOpenFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImporterDataFromXMLtoDataGridViewOpenFileDialog fImporterFichierXMLparFileDialog = new FormImporterDataFromXMLtoDataGridViewOpenFileDialog();
            fImporterFichierXMLparFileDialog.MdiParent = this;
            fImporterFichierXMLparFileDialog.Show();
        }

        private void deLaBaseDeDonnéesVersUnFihchierCSVAvecSaveFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportVersCSV ExportVersCSV = new FormExportVersCSV();
            ExportVersCSV.MdiParent = this;
            ExportVersCSV.Show();
        }
    }
}
