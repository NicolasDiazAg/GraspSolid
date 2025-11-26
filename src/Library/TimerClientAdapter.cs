namespace Full_GRASP_And_SOLID;

public class TimerClientAdapter : TimerClient
{
    // en este caso si o si se tendria que usar esta clase que se dedica a aplicar el patrón adapter.
    private Recipe recipe;

    public TimerClientAdapter(Recipe recipe)
    {
        this.recipe = recipe;
    }

    public void TimeOut()
    {
        recipe.OnCooked();
    }
}
