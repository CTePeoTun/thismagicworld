using System.Collections;
using System.Collections.Generic;
using TMW;
using UnityEngine;

public class GamePresenter
{
    private GameModel _model;
    private GameView _view;

    public GamePresenter(GameModel model, GameView view)
    {
        _model = model;
        _view = view;

        _model.OnMapReady = view.CreateMap;
    }

    public void CreateMap()
    {
        _model.CreateMap(3);
    }
    
}
