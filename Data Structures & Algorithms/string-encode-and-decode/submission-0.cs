public class Solution {

    public string Encode(IList<string> strs) 
    {
        string str = string.Join("", strs);
        string ender = "end ";

        foreach(string s in strs) 
        {
            ender += s.Length;
            ender += '#';
        }

        str += ender;

        return str;
    }

    public List<string> Decode(string s) 
    {
        int index = 0;
        int temp;
        int temp2 = 0;

        List<string> final = new List<string>();
        

        for(int i = s.Length - 1; i > -1; i--) 
        {
            if(s[i] == ' ') 
            {
                temp2 = i + 1;
                break;
            }
            

        }

        string number = "";
        for(int i = temp2; i < s.Length; i++) 
        {
            if(s[i] != '#') 
            {
                number += s[i];
                continue;
            }

            temp = int.Parse(number);

            number = "";
            
            
            
            string agh = "";
            

            for(int j = 0; j < temp; j++) 
            {
                agh += s[index];
                index++;
                
            }
            final.Add(agh);
        }

        return final;

    }
}
