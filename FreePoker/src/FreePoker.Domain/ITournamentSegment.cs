/**
* AKS 2.17.2026
* Interface implemented by Round and Break. 
* This allows us to have a list of Rounds and Breaks in the Tournament class, and we can easily determine if a segment is a Round or a Break.
* Thereby, Tournament will be modeled at a List<ITournamentSegment> TournamentSegments, which can contain both Rounds and Breaks.
*/
namespace FreePoker.Domain
{

    public enum TournamentSegment
    {
        Round,
        Break
    }

    public interface ITournamentSegment
    {
        int DurationInMinutes { get; }
        TournamentSegment SegmentType { get; }
    }

}