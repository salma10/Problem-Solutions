public class Solution {
    public string Multiply(string num1, string num2) {
       int n1 = num1.Length;
            int n2 = num2.Length;
            int[] products = new int[n1 + n2];

            for (int i = n1 - 1; i >= 0; i--)
            {
                for (int j = n2 - 1; j >= 0; j--)
                {
                    int p1 = i + j;
                    int p2 = p1 + 1;
                    int sum = (num1[i] - '0') * (num2[j] - '0') + products[p2];

                    products[p1] += sum / 10;
                    products[p2] = sum % 10;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach(int num in products)
            {
                if (!(sb.Length == 0 && num == 0))
                {
                    sb.Append(num);
                }
            }

            return sb.Length == 0 ? "0" : sb.ToString();
    }
}