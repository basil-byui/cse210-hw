using System;
using System.Collections.Generic;

class Video
{
    public string Title;
    public string Auther;
    public int Length; 
    public List<Comment> comments;
    
    // Constructor
    public Video(string aTitle, string anAuther, int aLength)
    {
        Title = aTitle;
        Auther = anAuther;
        Length = aLength;
        comments = new List<Comment>();
    }
    

    // Method to add comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // method to get the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }


    // Method to return List of comments
    public List<Comment> GetComments()
    {
        return comments;
    }

}