namespace InsConsole.models
{
    public class Visit
    {
        public long Id { get; set; }
        public string Date {get;set;}
    public long Person { get; set; }
    public string Provider { get; set; }

    public Visit(long Id_, string Date_, long Person_, string Provider_)
    {
        this.Id = Id_;
        this.Date = Date_;
        this.Person = Person_;
        this.Provider = Provider_;
    }
}
}