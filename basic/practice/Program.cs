System.Console.WriteLine(WordSplit(new string[] {"abcgefd", "a,ab,abc,abcg,b,c,dog,e,efd,zzzz"}));
// System.Console.WriteLine(WordSplit(new string[] {"baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z"}));



string WordSplit(string[] strArr)
{
    if (strArr.Length <=1) 
      return "not possible";

    string[] str = strArr[1].Split(",");

    // code goes here
    HashSet<string> previousWords = new();
    string firstItem = strArr[0];

    for(int x=1; x < str.Length; x++){
      var indx =  firstItem.IndexOf(str[x]);
      if (indx > -1) {
        string[] words = firstItem.Split(str[x]);
        if (words.Length > 1 && (words[0]=="" || words[1] ==""))
        {
          string firstWord = words[0];
          string secondWord = "";
          string searchWord = words[1];

          if(firstWord == "")
          {
            firstWord = str[x];
            secondWord = words[1];
          }
          else          {
            secondWord = str[x];
            searchWord = words[0];
          }


          if (previousWords.Contains(searchWord))
            return firstWord + "," + secondWord;
          else 
            previousWords.Add(str[x]);
        }  
      }

    }

    return "not possible";
}