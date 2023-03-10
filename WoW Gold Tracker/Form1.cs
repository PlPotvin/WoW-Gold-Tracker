using System.IO;
using System.Linq;

namespace WoW_Gold_Tracker
{
    public partial class Form1 : Form
    {
        public string defaultpath = @"C:\Program Files (x86)\World of Warcraft";

        public Form1()
        {
            InitializeComponent();
        }

        public static string[] ReadLinesFromFile(string filePath)
        {
            // On �crit un Array dynamique d'objet de type "string".
            List<string> linesList = new List<string>();

            // On instancie un object SR qui va lire le path ligne par ligne
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                // On lis le path LIGNE PAR LIGNE jusqu'� ce qu'il retourne rien.
                while ((line = sr.ReadLine()) != null)
                {
                    // Tant qu'il y a de quoi, on ajoute la ligne � notre Objet d'Array.
                    linesList.Add(line);
                }
            }

            // On retourne l'Object mais avant on r�cupere le contenu puis on le met dans un Array normal pour �tre trait�.
            return linesList.ToArray();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // On fait s�lectionner � l'utilisateur son dossier World of Warcraft.
            folderBroswer.ShowDialog(this);
            folderBroswer.SelectedPath = @"C:\Program Files (x86)\World of Warcraft";
            txt_path.Text = folderBroswer.SelectedPath;
        }

        public string[] GetPaths()
        {
            // On cr�e une fonction qui va chercher tous les dossiers avec GoldTracker.lua dedans. On met le r�sultat dans une variable "result" qui est retourn� pour �tre utilis� ult�rieurement.
            string searchFile = "GoldTracker.lua";
            var result = Directory.GetFiles(txt_path.Text, searchFile, SearchOption.AllDirectories).Where(f => f.Contains(searchFile)).Select(f => Path.GetDirectoryName(f)).Distinct().ToArray();
            return result;
        }

        public void ParseFile(string path)
        {
            // On call un Array de lignes avec la fonction.
            string[] lines = ReadLinesFromFile(path);

            // On d�finit les s�parateur qui d�finit ce qui va �tre retirer de la string.
            string[] separator = { " - ", "\"" };

            // Parsing du character.
            string[] character = lines[2].Split(separator[1]);

            // Parsing du realm.
            string realm = lines[3].Substring(13);
            realm = realm.Substring(0, realm.Length - 1);

            // Parsing du gold.
            string gold = lines[1].Substring(8);
            int goldint = Convert.ToInt32(gold) / 10000000;


            // On ajoute dans notre dataGridView la liste des personnages r�cup�r�s.
            dataGridView1.Rows.Add(character[1], realm, goldint + "k");
        }

        private void button_fetch_Click(object sender, EventArgs e)
        {
            // On met dans un Array les Paths de tous les dossiers qui contient "GoldTracker.lui"
            string[] paths = GetPaths();
            string[] luaPaths = new string[paths.Length];

            for (int i = 1; i < paths.Length; i++)
            {
                // On modifie chaque path pour y rajouter le nom du fichier. On met le nouveau path de fichier dans un Array.
                luaPaths[i] = paths[i] + "\\GoldTracker.lua";
            }

            for (int i = 1; i < luaPaths.Length; i++)
            {
                // On call la fonction pour parser le fichier lua. On passe la path en argument.
                ParseFile(luaPaths[i]);
            }

            // On sort le data en ordre d�croissant du gold du personnage.
            dataGridView1.Sort(dataGridView1.Columns["col_gold"], System.ComponentModel.ListSortDirection.Descending);

        }
    }
}