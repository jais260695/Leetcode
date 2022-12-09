public class Solution {
    public int[] MemLeak(int memory1, int memory2) {
        int i = 1;

        while(memory1>=i || memory2>=i)
        {
            if(memory1>=i)
            {
                if(memory1>=memory2)
                {
                    memory1-=i;
                }
                else
                {
                    memory2-=i;
                }             
                i++;
                continue;
            }
            
            if(memory2>=i)
            {
                memory2-=i;
                i++;
                continue;
            }
        }

        return new int[3]{i,memory1,memory2};
    }
}