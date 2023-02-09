namespace RadmsWebAPI.ViewModels.BaseModel
{
    public interface ViewBaseModel
    {
        T MapToViewEntity<T>() where T : class;

    }
}
