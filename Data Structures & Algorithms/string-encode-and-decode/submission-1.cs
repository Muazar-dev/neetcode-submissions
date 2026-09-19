public class Solution {

    public string Encode(IList<string> strs) {
        
        string temp = "";

        foreach(string s in strs) {
           

            temp += s.Length;

            temp +='#';

            temp += s;
        }

        return temp;
    }

    public List<string> Decode(string s) {

        string number = "";
        int chars = 0;
        string currentstr = "";
        List<string> final = new List<string>();
        
       for(int j = 0; j < s.Length; j++) {
            
           if(s[j] == '#')
           {
            chars = int.Parse(number);
            number = "";
            j++;
                for(int i = 0; i < chars; i++)  
                {
                    currentstr +=  s[j];
                    j++;

                }
                final.Add(currentstr);
                currentstr = "";
                j--;
                continue;
           }

            number += s[j];
            


        }
        return final;
   }
}
