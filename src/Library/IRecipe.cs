namespace Full_GRASP_And_SOLID;

public interface IRecipe
{
    public void AddStep(Product input, double quantity, Equipment equipment, int time);
    public void AddStep(string description, int time);
    public void RemoveStep(BaseStep step);
    public string GetTextToPrint();
    public double GetProductionCost();

}