class Duck : Bird
{
    public double size { get; set; }
    public String kind { get; set; }

    public override string ToString()
    {
        return $"A duck name {name} is a {size} inch {kind}";
    }
}