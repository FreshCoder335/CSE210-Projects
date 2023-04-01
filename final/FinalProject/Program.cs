// Jeremiah Powell 
// 3/21/23
using System;

class Program
{
    static void Main(string[] args)
    {
        JPmenu JPopenMenu = new JPmenu();
        JPorderShipment JPfilledOrder = new JPorderShipment();
        JPmunitionSpecs JPbulletStuff = new JPmunitionSpecs();
        JPfirearmSpecs JPfirearmDeats = new JPfirearmSpecs("16 inches", "8 pounds", "500RPM", "Daniel Defense", "M4A1 model 2", "tactical sporting rifle", "30 standardized","5.56MM");
        JPinventory JPdisplayInfo = new JPinventory();
        JPfileManager JPreadFile = new JPfileManager();

        JPopenMenu.JPmenuSelection();
        string JPgivenSelection = JPopenMenu.JPuserSelection();

        
        List<string>JPdisplayFirearms = new List<string>();
        JPdisplayFirearms.Add(JPfirearmDeats.JPtoString());
        JPreadFile.JPfileSave(JPdisplayFirearms);

        if(JPgivenSelection == "2")
        {
        JPdisplayInfo.JPaddFirearm(JPfirearmDeats.JPtoString());
        JPdisplayInfo.JPshowFirearms();
        }
    }
}