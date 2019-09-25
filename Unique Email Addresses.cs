public int NumUniqueEmails(string[] emails) {
        for(int i = 0; i < emails.Length; i++)
        {
            if(emails[i] != "" && emails[i] != null)
            {
                var split = emails[i].Split('@');
                string less = split[0].Replace(".","").Trim();;
                int index = less.IndexOf("+");
                if (index > 0)
                    less = less.Substring(0, index);
                emails[i] = less + "@" + split[1];
            }            
        }   
       return emails.Distinct().Count(); 

    }
