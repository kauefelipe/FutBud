using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mime;
using System.Windows.Forms;
using FutBud.Services;
using MetroFramework.Forms;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Models;

namespace FutBud
{
    public partial class FormSupport : MetroForm
    {
        public FormSupport()
        {
            InitializeComponent();
            
        }

        /* 
        ||====================================================================||
        ||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||
        ||(100)==================| FEDERAL RESERVE NOTE |================(100)||
        ||\\$//        ~         '------========--------'                \\$//||
        ||<< /        /$\              // ____ \\                         \ >>||
        ||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||
        ||<<|        \\ //           || <||  >\  ||                        |>>||
        ||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
        ||<<|      L38036133B        *\\  |\_/  //* series                 |>>||
        ||>>|  12                     *\\/___\_//*   1989                  |<<||
        ||<<\      Treasurer     ______/Franklin\________     Secretary 12 />>||
        ||//$\                 ~|UNITED STATES OF Murrica|~               /$\\||
        ||(100)===================  ONE HUNDRED DOLLARS =================(100)||
        ||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
        ||====================================================================||
        */
        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=C3LEHJLSTX326");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.g2a.com/?reflink=futbuddy");
        }

        private void btnThanks_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
