﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MovieFacade
{
	public virtual bool HasBeenPlayed
	{
		get;
		set;
	}

	public virtual void Play(string movieName)
	{
        //IPlayer player = PlayerFactory.CreatePlayer(movieName);
        //player.PlayMovie("Star Wars 3", 2003, "http://www.imdb.com/starwars3", "Peter Mayhew");

        this.HasBeenPlayed = true;
    }

}
