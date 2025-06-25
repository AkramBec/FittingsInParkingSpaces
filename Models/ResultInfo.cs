namespace FittingsInParkingSpaces.Models;

public class ResultInfo
{
    private readonly Element _element;
    private readonly TitleInfo _titleInfo;
    
    public int ElementId {get;}
    public string Category {get;}
    public string SystemClassification {get;}
    public string Name {get;}
    public string Designation {get;}
    public string DocumentTitle {get;}
    public string Discipline { get; }
    public string ViewName { get;}
    public ElementId ViewId { get;}
    
    public ResultInfo(Element element, string documentTitle, ElementId viewId)
    {
        _element = element;
        DocumentTitle = documentTitle;
        ViewId = viewId;

        ElementId = element.Id.IntegerValue;
        Category = element.Category?.Name ?? "Нет категории";
        SystemClassification = element.get_Parameter(BuiltInParameter.RBS_SYSTEM_NAME_PARAM).AsString();
        
        Guid nameGuid = new Guid("e6e0f5cd-3e26-485b-9342-23882b20eb43");
        Guid designationGuid = new Guid("9c98831b-9450-412d-b072-7d69b39f4029");
        Name = element.get_Parameter(nameGuid).AsString();
        Designation = element.get_Parameter(designationGuid).AsString();

        if (documentTitle != "")
        {
            Discipline = TitleInfo.Discipline(documentTitle);
            ViewName = $"{Discipline}_{Category}_{ElementId}";
        }
        else
        {
            ViewName = $"{Category}_{ElementId}";
        }
    }

    public override string ToString()
    {
        if (DocumentTitle != "")
        {
            return $"{Discipline} : {ElementId}, Категория: {Category}";
        }
        else
        {
            return $"{ElementId}, Категория: {Category}";
        }
        
    }
}