namespace Controllers 
{
  public abstract class AbstractController {
    public void IsFound(object? o) {
      if (o == null) {
        throw new Exception("Null");
      }
    }
  }
}