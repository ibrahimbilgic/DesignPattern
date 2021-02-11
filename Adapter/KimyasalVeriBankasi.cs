namespace Adapter
{
    class KimyasalVeriBankasi
    {
        public float GetKritikNokta(string bilesik,string nokta){
            if(nokta == "M"){
                switch(bilesik.ToLower()){
                    case "su":return 0.0f;
                    case "benzen":return 5.5f;
                    case "ethanol":return -114.1f;
                    default:return 0f;
                }
            }
            else{
                switch(bilesik.ToLower()){
                    case "su":return 100.0f;
                    case "benzen":return 80.1f;
                    case "ethanol": return 78.3f;
                    default:return 0f;
                }
            }
        }
        public string GetMolekulerYapi(string bilesik){
            switch(bilesik.ToLower()){
                case "su":return "H2O";
                case "benzen":return "C6H6";
                case "ethanol":return "C2H5OH";
                default:return "";
            }

        }
        public double GetMolekulerAgirlik(string bilesik){
            switch(bilesik.ToLower()){
                case "su":return 18.015;
                case "benzen":return 78.1134;
                case "ethanol":return 46.0688;
                default:return 0d;
            }
        }
    }
}