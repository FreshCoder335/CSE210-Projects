// Jeremiah Powell 
// 3/21/23
using System;

class Program
{
    static void Main(string[] args)
    {
        JPmenu JPopenMenu = new JPmenu();
        JPorderShipment JPfilledOrder = new JPorderShipment("An order for 100,000 more units of manufature products have been ordered","current Inventory is 75,000 units");
        JPmunitionSpecs JPbulletStuff = new JPmunitionSpecs("69 grains","2.2 inches", "3250 feet per second");
        JPfirearmSpecs JPfirearmDeats = new JPfirearmSpecs("16 inches", "8 pounds", "500RPM", "Daniel Defense", "M4A1 model 2", "tactical sporting rifle", "30 standardized","5.56MM");
        JPinventory JPdisplayInfo = new JPinventory();
        JPfileManager JPreadFile = new JPfileManager();
        bool JPloopProgram = true;

        while (JPloopProgram)
        {
            JPopenMenu.JPmenuSelection();
            string JPgivenSelection = JPopenMenu.JPuserSelection();
    
            
            List<string>JPdisplayFirearms = new List<string>();
            JPdisplayFirearms.Add(JPfirearmDeats.JPtoString());
            JPreadFile.JPfileSave(JPdisplayFirearms);
    
            if(JPgivenSelection == "2")
            {
            JPdisplayInfo.JPaddFirearm(JPfirearmDeats.JPtoString());
            JPdisplayInfo.JPaddFirearm(JPbulletStuff.JPtoString());
            JPdisplayInfo.JPshowFirearms();
            }
            else if(JPgivenSelection == "1")
            {
                JPdisplayInfo.JPaddFirearm(JPfilledOrder.JPtoString());
                JPdisplayInfo.JPshowFirearms();
            }
            else if(JPgivenSelection == "3")
            {
                System.Environment.Exit(0);
                JPloopProgram = false;
            }
        }
    }
}