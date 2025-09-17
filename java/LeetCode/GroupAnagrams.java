class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
      
        Hashtable<String, List<String>> ht = new Hashtable<String, List<String>>();

        for(String str:strs){
            char[] chars = str.toCharArray();
            Arrays.sort(chars);
          
            //do not use .toString() as that will just return the reference and not the new string.
            String newStr = new String(chars);
            if(ht.containsKey(newStr)){
                ht.get(newStr).add(str);
            }
            else{
                ht.put(newStr, new ArrayList<>(List.of(str)));
            }
        }

        List<List<String>> values = new ArrayList<>(ht.values());

        return values;
    }
}
