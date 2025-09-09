public class Logger {

    public Dictionary<string,int> m_cooldownTimeDictionary;
    public Logger() {
         m_cooldownTimeDictionary = new Dictionary<string,int> ();
    }
    
    public bool ShouldPrintMessage(int timestamp, string message) 
    {
        if(!m_cooldownTimeDictionary.TryGetValue(message,out var cooldown) || timestamp>=cooldown)
        {
            m_cooldownTimeDictionary[message] = timestamp +10;
            return true;
        }
        return false;
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */