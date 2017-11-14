using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class AllStateReleasePercentages
{
    public  StatePercents WA;
    public  StatePercents DE;
    public  StatePercents DC;
    public  StatePercents WI;
    public  StatePercents WV;
    public  StatePercents FL;
    public  StatePercents WY;
    public  StatePercents NH;
    public  StatePercents NJ;
    public  StatePercents NM;
    public  StatePercents TX;
    public  StatePercents LA;
    public  StatePercents NC;
    public  StatePercents ND;
    public  StatePercents NE;
    public  StatePercents TN;
    public  StatePercents NY;
    public  StatePercents PA;
    public  StatePercents CT;
    public  StatePercents RI;
    public  StatePercents NV;
    public  StatePercents VA;
    public  StatePercents CO;
    public  StatePercents CA;
    public  StatePercents AL;
    public  StatePercents AS;
    public  StatePercents AR;
    public  StatePercents VT;
    public  StatePercents IL;
    public  StatePercents GA;
    public  StatePercents IN;
    public  StatePercents IA;
    public  StatePercents MA;
    public  StatePercents AZ;
    public  StatePercents ID;
    public  StatePercents ME;
    public  StatePercents MD;
    public  StatePercents OK;
    public  StatePercents OH;
    public  StatePercents UT;
    public  StatePercents MO;
    public  StatePercents MN;
    public  StatePercents MI;
    public  StatePercents KS;
    public  StatePercents MT;
    public  StatePercents MS;
    public  StatePercents SC;
    public  StatePercents KY;
    public  StatePercents OR;
    public  StatePercents SD;
    public  StatePercents HI;
    public  StatePercents AK;
    /*
    public static StatePercents[] statePer = new StatePercents[] {AL, AK, AZ, AR, CA, CO, CT, DE, FL, GA, HI, ID, IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO, MT, NE,
    NV, NH, NJ, NM, NY, NC, ND, OH, OK, OR, PA, RI, SC, SD, TN, TX, UT, VT, VA, WA, WV, WI, WY};
    */
}

[System.Serializable]
public class StatePercents
{
    public float CLEAR_AIR_ACT_CHEMICAL;
    public float CARCINOGEN;
    public float METAL;
    public float FEDERAL_FACILITY;
    
}

public class StatePercentages : MonoBehaviour {

    public int year = 2015;
    public static int t = 0; //1= clearair, 2=carcinogen, 3=Metal, 4=Federal

    //Materials
    
    public Material AlabamaMaterial;
    public Material AlaskaMaterial;
    public Material ArizonaMaterial;
    public Material ArkansasMaterial;
    public Material CaliforniaMaterial;
    public Material ColoradoMaterial;
    public Material ConnecticutMaterial;
    public Material DelawareMaterial;
    public Material FloridaMaterial;
    public Material GeorgiaMaterial;
    public Material HawaiiMaterial;
    public Material IdahoMaterial;
    public Material IllinoisMaterial;
    public Material IndianaMaterial;
    public Material IowaMaterial;
    public Material KansasMaterial;
    public Material KentuckyMaterial;
    public Material LouisianaMaterial;
    public Material MaineMaterial;
    public Material MarylandMaterial;
    public Material MassachusettsMaterial;
    public Material MichiganMaterial;
    public Material MinnesotaMaterial;
    public Material MississippiMaterial;
    public Material MissouriMaterial;
    public Material MontanaMaterial;
    public Material NebraskaMaterial;
    public Material NevadaMaterial;
    public Material NewHampshireMaterial;
    public Material NewJerseyMaterial;
    public Material NewMexicoMaterial;
    public Material NewYorkMaterial;
    public Material NorthCarolinaMaterial;
    public Material NorthDakotaMaterial;
    public Material OhioMaterial;
    public Material OklahomaMaterial;
    public Material OregonMaterial;
    public Material PennsylvaniaMaterial;
    public Material RhodeIslandMaterial;
    public Material SouthCarolinaMaterial;
    public Material SouthDakotaMaterial;
    public Material TennesseeMaterial;
    public Material TexasMaterial;
    public Material UtahMaterial;
    public Material VermontMaterial;
    public Material VirginiaMaterial;
    public Material WashingtonMaterial;
    public Material WestVirginiaMaterial;
    public Material WisconsinMaterial;
    public Material WyomingMaterial;
    /*public Material[] Mats = new Material[] { AlabamaMaterial, AlaskaMaterial, ArizonaMaterial, ArkansasMaterial, CaliforniaMaterial, ColoradoMaterial, ConnecticutMaterial, DelawareMaterial, FloridaMaterial,
        GeorgiaMaterial, HawaiiMaterial, IdahoMaterial, IllinoisMaterial, IndianaMaterial, IowaMaterial, KansasMaterial, KentuckyMaterial, LouisianaMaterial, MaineMaterial, MarylandMaterial, MassachusettsMaterial, MichiganMaterial,
        MinnesotaMaterial, MississippiMaterial, MissouriMaterial, MontanaMaterial, NebraskaMaterial, NevadaMaterial, NewHampshireMaterial, NewJerseyMaterial, NewMexicoMaterial, NewYorkMaterial, NorthCarolinaMaterial,
        NorthDakotaMaterial, OhioMaterial, OklahomaMaterial, OregonMaterial, PennsylvaniaMaterial, RhodeIslandMaterial, SouthCarolinaMaterial, SouthDakotaMaterial, TennesseeMaterial, TexasMaterial, UtahMaterial,
        VermontMaterial, VirginiaMaterial, WashingtonMaterial, WestVirginiaMaterial, WisconsinMaterial, WyomingMaterial};
        */
    private void Awake()
    {
        //ClearActMap();
        //CarcMap();
    }

    void Update()
    {
        int i = 0;
        /*
        if (true)
        {//somehow change which type. if else system based on buttun press?
            i = 0;
            ClearActMap(i);
        }
        */
        if (Input.GetKeyDown("up") || Input.GetKeyDown("right") || Input.GetButtonDown("Gamepad_B"))
        {
            year++;
            if (year > 2015)
            {
                year = 2009;
            }
            Debug.Log("Increased year to: " + year);
            //ClearActMap();
            //CarcMap();
        }

        if (Input.GetKeyDown("down") || Input.GetKeyDown("left") || Input.GetButtonDown("Gamepad_X"))
        {
            year--;
            if (year < 2009)
            {
                year = 2015;
            }
            Debug.Log("Decreased year to: " + year);
            //ClearActMap();
            //CarcMap();
        }
    }

    void ClearActMap()
    {
        string dataAsJson = File.ReadAllText("Assets/Data/StatePercentages" + year + ".json");
        AllStateReleasePercentages percents = JsonUtility.FromJson<AllStateReleasePercentages>(dataAsJson);
        //float[] typeArray = {StatePercents.CLEAR_AIR_ACT_CHEMICAL, StatePercents.CARCINOGEN, StatePercents.METAL, StatePercents.FEDERAL_FACILITY};

        //Debug.Log("AK METAL: " + percents.AK.METAL + "%");

        float valueScaled;
        float red;
        float green;
        float blue;

       /*
            //float ty = StatePercents.types[t];
            valueScaled = AllStateReleasePercentages.statePer[i].types[0];
            //valueScaled = percents.AL.CLEAR_AIR_ACT_CHEMICAL;
            if (valueScaled < 50)
            {
                red = 0;
                green = 0;
                blue = (valueScaled / 50) * 255;
                 = new Color(red, green, blue, 1);
            }
            else if (valueScaled == 50)
            {
                red = 0;
                green = 0;
                blue = 0;
                 = new Color(red, green, blue, 1);
            }
            else if (valueScaled > 50)
            {
                red = 255 * ((valueScaled - 50) / 50);
                green = 255 * ((valueScaled - 50) / 50);
                blue = 0;
                 = new Color(red, green, blue, 1);
            }
           */ 
        

        
        valueScaled = percents.AL.CLEAR_AIR_ACT_CHEMICAL;
        if(valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            AlabamaMaterial.color = new Color(red, green, blue, 1);
        }
        else if(valueScaled == 50){
            red = 0;
            green = 0;
            blue = 0;
            AlabamaMaterial.color = new Color(red, green, blue, 1);
        }
        else if(valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            AlabamaMaterial.color = new Color(red, green, blue, 1);
        }
        //Debug.Log("Alabama:" + valueScaled);
        //AlabamaMaterial.color = new Color(red, green, blue, 1);
        valueScaled = (percents.AK.CLEAR_AIR_ACT_CHEMICAL/ 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            AlaskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            AlaskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            AlaskaMaterial.color = new Color(red, green, blue, 1);
        }
        //AlaskaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        //AlaskaMaterial.color = new Color(0, 0, 255, 1);
        valueScaled = (percents.AZ.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ArizonaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ArizonaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            ArizonaMaterial.color = new Color(red, green, blue, 1);
        }
        //ArizonaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.AR.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ArkansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ArkansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            ArkansasMaterial.color = new Color(red, green, blue, 1);
        }
        //ArkansasMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.CA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            CaliforniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            CaliforniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            CaliforniaMaterial.color = new Color(red, green, blue, 1);
        }
        //CaliforniaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.CO.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ColoradoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ColoradoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            ColoradoMaterial.color = new Color(red, green, blue, 1);
        }
        //ColoradoMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.CT.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ConnecticutMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ConnecticutMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            ConnecticutMaterial.color = new Color(red, green, blue, 1);
        }
        //ConnecticutMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.DE.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            DelawareMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            DelawareMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            DelawareMaterial.color = new Color(red, green, blue, 1);
        }
        //DelawareMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.FL.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            FloridaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            FloridaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            FloridaMaterial.color = new Color(red, green, blue, 1);
        }
        //FloridaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.GA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            GeorgiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            GeorgiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            GeorgiaMaterial.color = new Color(red, green, blue, 1);
        }
        //GeorgiaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.HI.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            HawaiiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            HawaiiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            HawaiiMaterial.color = new Color(red, green, blue, 1);
        }
        //HawaiiMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.ID.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IdahoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IdahoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            IdahoMaterial.color = new Color(red, green, blue, 1);
        }
        //IdahoMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.IL.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IllinoisMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IllinoisMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            IllinoisMaterial.color = new Color(red, green, blue, 1);
        }
        //IllinoisMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.IN.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IndianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IndianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            IndianaMaterial.color = new Color(red, green, blue, 1);
        }
        //IndianaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.IA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IowaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IowaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            IowaMaterial.color = new Color(red, green, blue, 1);
        }
        //IowaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.KS.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            KansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            KansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            KansasMaterial.color = new Color(red, green, blue, 1);
        }
        //KansasMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.KY.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            KentuckyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            KentuckyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            KentuckyMaterial.color = new Color(red, green, blue, 1);
        }
        //KentuckyMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.LA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            LouisianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            LouisianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            LouisianaMaterial.color = new Color(red, green, blue, 1);
        }
        //LouisianaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.ME.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MaineMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MaineMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MaineMaterial.color = new Color(red, green, blue, 1);
        }
        //MaineMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MD.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MarylandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MarylandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MarylandMaterial.color = new Color(red, green, blue, 1);
        }
        //MarylandMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MassachusettsMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MassachusettsMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MassachusettsMaterial.color = new Color(red, green, blue, 1);
        }
        //MassachusettsMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MI.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MichiganMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MichiganMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MichiganMaterial.color = new Color(red, green, blue, 1);
        }
        //MichiganMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MN.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MinnesotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MinnesotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MinnesotaMaterial.color = new Color(red, green, blue, 1);
        }
        //MinnesotaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MS.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MississippiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MississippiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MississippiMaterial.color = new Color(red, green, blue, 1);
        }
        //MississippiMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MO.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MissouriMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MissouriMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MissouriMaterial.color = new Color(red, green, blue, 1);
        }
        //MissouriMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MT.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MontanaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MontanaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            MontanaMaterial.color = new Color(red, green, blue, 1);
        }
        //MontanaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NE.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NebraskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NebraskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NebraskaMaterial.color = new Color(red, green, blue, 1);
        }
        //NebraskaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NV.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NevadaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NevadaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NevadaMaterial.color = new Color(red, green, blue, 1);
        }
        //NevadaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NH.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewHampshireMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewHampshireMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NewHampshireMaterial.color = new Color(red, green, blue, 1);
        }
        //NewHampshireMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NJ.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewJerseyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewJerseyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NewJerseyMaterial.color = new Color(red, green, blue, 1);
        }
        //NewJerseyMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NM.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewMexicoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewMexicoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NewMexicoMaterial.color = new Color(red, green, blue, 1);
        }
        //NewMexicoMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NY.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewYorkMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewYorkMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NewYorkMaterial.color = new Color(red, green, blue, 1);
        }
        //NewYorkMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NC.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NorthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NorthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NorthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        //NorthCarolinaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.ND.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NorthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NorthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            NorthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        //NorthDakotaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.OH.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            OhioMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            OhioMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            OhioMaterial.color = new Color(red, green, blue, 1);
        }
        //OhioMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.OK.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            OklahomaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            OklahomaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            OklahomaMaterial.color = new Color(red, green, blue, 1);
        }
        //OklahomaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.OR.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        Debug.Log("Oregon: " + valueScaled);
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            OregonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            OregonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            OregonMaterial.color = new Color(red, green, blue, 1);
        }
        //OregonMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.PA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            PennsylvaniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            PennsylvaniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            PennsylvaniaMaterial.color = new Color(red, green, blue, 1);
        }
        //PennsylvaniaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.RI.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            RhodeIslandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            RhodeIslandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            RhodeIslandMaterial.color = new Color(red, green, blue, 1);
        }
        //RhodeIslandMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.SC.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            SouthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            SouthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            SouthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        //SouthCarolinaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.SD.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            SouthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            SouthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            SouthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        //SouthDakotaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.TN.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            TennesseeMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            TennesseeMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            TennesseeMaterial.color = new Color(red, green, blue, 1);
        }
        //TennesseeMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.TX.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            TexasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            TexasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            TexasMaterial.color = new Color(red, green, blue, 1);
        }
        //TexasMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.UT.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            UtahMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            UtahMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            UtahMaterial.color = new Color(red, green, blue, 1);
        }
        //UtahMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.VT.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            VermontMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            VermontMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            VermontMaterial.color = new Color(red, green, blue, 1);
        }
        //VermontMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.VA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            VirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            VirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            VirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        //VirginiaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WA.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WashingtonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WashingtonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            WashingtonMaterial.color = new Color(red, green, blue, 1);
        }
        //WashingtonMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WV.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WestVirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WestVirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            WestVirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        //WestVirginiaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WI.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WisconsinMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WisconsinMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            WisconsinMaterial.color = new Color(red, green, blue, 1);
        }
        //WisconsinMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WY.CLEAR_AIR_ACT_CHEMICAL / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WyomingMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WyomingMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            green = 255 * ((valueScaled - 50) / 50);
            blue = 0;
            WyomingMaterial.color = new Color(red, green, blue, 1);
        }
        //WyomingMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        
    }

    void CarcMap()
    {
        string dataAsJson = File.ReadAllText("Assets/Data/StatePercentages" + year + ".json");
        AllStateReleasePercentages percents = JsonUtility.FromJson<AllStateReleasePercentages>(dataAsJson);
        //float[] typeArray = {StatePercents.CLEAR_AIR_ACT_CHEMICAL, StatePercents.CARCINOGEN, StatePercents.METAL, StatePercents.FEDERAL_FACILITY};

        //Debug.Log("AK METAL: " + percents.AK.METAL + "%");

        float valueScaled;
        float red;
        float green;
        float blue;

        valueScaled = percents.AL.CARCINOGEN;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            AlabamaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            AlabamaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            AlabamaMaterial.color = new Color(red, green, blue, 1);
        }
        //Debug.Log("Alabama:" + valueScaled);
        //AlabamaMaterial.color = new Color(red, green, blue, 1);
        valueScaled = (percents.AK.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            AlaskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            AlaskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            AlaskaMaterial.color = new Color(red, green, blue, 1);
        }
        //AlaskaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        //AlaskaMaterial.color = new Color(0, 0, 255, 1);
        valueScaled = (percents.AZ.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ArizonaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ArizonaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            ArizonaMaterial.color = new Color(red, green, blue, 1);
        }
        //ArizonaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.AR.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ArkansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ArkansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            ArkansasMaterial.color = new Color(red, green, blue, 1);
        }
        //ArkansasMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.CA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            CaliforniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            CaliforniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            CaliforniaMaterial.color = new Color(red, green, blue, 1);
        }
        //CaliforniaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.CO.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ColoradoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ColoradoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            ColoradoMaterial.color = new Color(red, green, blue, 1);
        }
        //ColoradoMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.CT.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            ConnecticutMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            ConnecticutMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            ConnecticutMaterial.color = new Color(red, green, blue, 1);
        }
        //ConnecticutMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.DE.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            DelawareMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            DelawareMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            DelawareMaterial.color = new Color(red, green, blue, 1);
        }
        //DelawareMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.FL.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            FloridaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            FloridaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            FloridaMaterial.color = new Color(red, green, blue, 1);
        }
        //FloridaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.GA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            GeorgiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            GeorgiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            GeorgiaMaterial.color = new Color(red, green, blue, 1);
        }
        //GeorgiaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.HI.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            HawaiiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            HawaiiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            HawaiiMaterial.color = new Color(red, green, blue, 1);
        }
        //HawaiiMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.ID.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IdahoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IdahoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            IdahoMaterial.color = new Color(red, green, blue, 1);
        }
        //IdahoMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.IL.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IllinoisMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IllinoisMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            IllinoisMaterial.color = new Color(red, green, blue, 1);
        }
        //IllinoisMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.IN.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IndianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IndianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            IndianaMaterial.color = new Color(red, green, blue, 1);
        }
        //IndianaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.IA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            IowaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            IowaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            IowaMaterial.color = new Color(red, green, blue, 1);
        }
        //IowaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.KS.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            KansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            KansasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            KansasMaterial.color = new Color(red, green, blue, 1);
        }
        //KansasMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.KY.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            KentuckyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            KentuckyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            KentuckyMaterial.color = new Color(red, green, blue, 1);
        }
        //KentuckyMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.LA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            LouisianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            LouisianaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            LouisianaMaterial.color = new Color(red, green, blue, 1);
        }
        //LouisianaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.ME.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MaineMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MaineMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MaineMaterial.color = new Color(red, green, blue, 1);
        }
        //MaineMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1); 
        valueScaled = (percents.MD.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MarylandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MarylandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MarylandMaterial.color = new Color(red, green, blue, 1);
        }
        //MarylandMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MassachusettsMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MassachusettsMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MassachusettsMaterial.color = new Color(red, green, blue, 1);
        }
        //MassachusettsMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MI.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MichiganMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MichiganMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MichiganMaterial.color = new Color(red, green, blue, 1);
        }
        //MichiganMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MN.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MinnesotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MinnesotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MinnesotaMaterial.color = new Color(red, green, blue, 1);
        }
        //MinnesotaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MS.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MississippiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MississippiMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MississippiMaterial.color = new Color(red, green, blue, 1);
        }
        //MississippiMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MO.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MissouriMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MissouriMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MissouriMaterial.color = new Color(red, green, blue, 1);
        }
        //MissouriMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.MT.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            MontanaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            MontanaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            MontanaMaterial.color = new Color(red, green, blue, 1);
        }
        //MontanaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NE.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NebraskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NebraskaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NebraskaMaterial.color = new Color(red, green, blue, 1);
        }
        //NebraskaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NV.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NevadaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NevadaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NevadaMaterial.color = new Color(red, green, blue, 1);
        }
        //NevadaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NH.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewHampshireMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewHampshireMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NewHampshireMaterial.color = new Color(red, green, blue, 1);
        }
        //NewHampshireMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NJ.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewJerseyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewJerseyMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NewJerseyMaterial.color = new Color(red, green, blue, 1);
        }
        //NewJerseyMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NM.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewMexicoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewMexicoMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NewMexicoMaterial.color = new Color(red, green, blue, 1);
        }
        //NewMexicoMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NY.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NewYorkMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NewYorkMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NewYorkMaterial.color = new Color(red, green, blue, 1);
        }
        //NewYorkMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.NC.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NorthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NorthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NorthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        //NorthCarolinaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.ND.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            NorthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            NorthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            NorthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        //NorthDakotaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.OH.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            OhioMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            OhioMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            OhioMaterial.color = new Color(red, green, blue, 1);
        }
        //OhioMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.OK.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            OklahomaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            OklahomaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            OklahomaMaterial.color = new Color(red, green, blue, 1);
        }
        //OklahomaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.OR.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            OregonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            OregonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            OregonMaterial.color = new Color(red, green, blue, 1);
        }
        //OregonMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.PA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            PennsylvaniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            PennsylvaniaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            PennsylvaniaMaterial.color = new Color(red, green, blue, 1);
        }
        //PennsylvaniaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.RI.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            RhodeIslandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            RhodeIslandMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            RhodeIslandMaterial.color = new Color(red, green, blue, 1);
        }
        //RhodeIslandMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.SC.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            SouthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            SouthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            SouthCarolinaMaterial.color = new Color(red, green, blue, 1);
        }
        //SouthCarolinaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.SD.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            SouthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            SouthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            SouthDakotaMaterial.color = new Color(red, green, blue, 1);
        }
        //SouthDakotaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.TN.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            TennesseeMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            TennesseeMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            TennesseeMaterial.color = new Color(red, green, blue, 1);
        }
        //TennesseeMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.TX.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            TexasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            TexasMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            TexasMaterial.color = new Color(red, green, blue, 1);
        }
        //TexasMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.UT.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            UtahMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            UtahMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            UtahMaterial.color = new Color(red, green, blue, 1);
        }
        //UtahMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.VT.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            VermontMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            VermontMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            VermontMaterial.color = new Color(red, green, blue, 1);
        }
        //VermontMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.VA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            VirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            VirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            VirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        //VirginiaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WA.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WashingtonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WashingtonMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            WashingtonMaterial.color = new Color(red, green, blue, 1);
        }
        //WashingtonMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WV.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WestVirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WestVirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            WestVirginiaMaterial.color = new Color(red, green, blue, 1);
        }
        //WestVirginiaMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WI.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WisconsinMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WisconsinMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            WisconsinMaterial.color = new Color(red, green, blue, 1);
        }
        //WisconsinMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
        valueScaled = (percents.WY.CARCINOGEN / 100) * 255;
        if (valueScaled < 50)
        {
            red = 0;
            green = 0;
            blue = (valueScaled / 50) * 255;
            WyomingMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled == 50)
        {
            red = 0;
            green = 0;
            blue = 0;
            WyomingMaterial.color = new Color(red, green, blue, 1);
        }
        else if (valueScaled > 50)
        {
            red = 255 * ((valueScaled - 50) / 50);
            blue = 255 * ((valueScaled - 50) / 50);
            green = 0;
            WyomingMaterial.color = new Color(red, green, blue, 1);
        }
        //WyomingMaterial.color = new Color(valueScaled, valueScaled, 255 - valueScaled, 1);
    }

    void MetalMap()
    {

    }

    void FederalMap()
    {

    }
}
