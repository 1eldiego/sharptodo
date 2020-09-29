namespace sharptodo
{
  class Task
  {
    private string desc;
    private bool done;

    public Task(string _desc)
    {
      desc = _desc;
    }

    public void setDone(bool _done)
    {
      done = _done;
    }

    public bool getDone()
    {
      return done;
    }

    public string getDesc()
    {
      return desc;
    }

    public string toText() {
      return "[" + (done ? "X" : " ") + "] " + desc;
    }
  }
}
