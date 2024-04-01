using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSelect : MonoBehaviour
{
    public Avatar SelectedAvatar { get; private set; }
    public Avatar blue;
    public Avatar red;

    public void SetSelected(Avatar avatar)
    {
        if (SelectedAvatar != null)
        {
            SelectedAvatar.force = 0;
            SelectedAvatar.Selected(false);
        }
        SelectedAvatar = avatar;
        SelectedAvatar.Selected(true);
    }
}
