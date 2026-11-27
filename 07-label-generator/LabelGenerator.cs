using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class LabelGenerator
{
   
    public string CreateLabel(string rawText)
    {
        // TODO: Bruk den private helperen og returner f.eks. "LABEL: LUNAR SAMPLE".
        
       
        return Normalize("label: "+rawText);
        
    }


    private string Normalize(string rawText)
    {
        // TODO: Trim og gjør teksten uppercase.
        rawText= rawText.Trim();
        rawText = rawText.ToUpper();    
        return rawText;
        
    }

    
}
