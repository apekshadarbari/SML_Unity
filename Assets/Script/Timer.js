#pragma strict


var timer : float = 31.0;

function Update()
{ 
  
    timer -= Time.deltaTime;
       if (timer<=0)
    {    timer = 0;
    }
}

function OnGUI()
{    
    GUI.Box(new Rect(800,80,60,20), "" + timer.ToString("0"));
    
}

