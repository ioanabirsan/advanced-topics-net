using Studies.models;

namespace Studies.api
{
    public interface IObjectWithState
    {
        State State { get; set; }
    }
}