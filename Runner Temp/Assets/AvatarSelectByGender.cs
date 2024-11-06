/*using ReadyPlayerMe.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSelectByGender : MonoBehaviour
{

    public static AvatarSelectByGender instace;
    public string send_url;
    public GameObject avatar;
    public AvatarObjectLoader RuntimeExample;
    public Avatar femaleAvatar, MaleAvatar;
    public GameObject AmatureRPM, RendereRPM;
    public Shader shaderUnlit;


    public string tempURl;
    [ContextMenu("RPM")]
    public void CallLoadAvatar()
    {
        LoadAvatarRuntime(tempURl);
    }


    void Awake()
    {
        if (instace != null && instace != this)
        {
            Destroy(gameObject);
            return;
        }

        instace = this;
    }
    public void LoadAvatarRuntime(string url)
    {
        //isPermitedToMove = false;
        //GameManager.Instance.isplay = false;

        send_url = url;
        Debug.Log("send url-----------------------" + send_url);

        if (AmatureRPM != null)
        {
            print("Destryo");
            Destroy(AmatureRPM.gameObject);
            Destroy(RendereRPM.gameObject);
        }

        RuntimeExample = new AvatarObjectLoader();
        RuntimeExample.OnCompleted += OnLoadCompleted;
        RuntimeExample.OnFailed += OnLoadFailed;


        RuntimeExample.LoadAvatar(url);
        //   startchecking = true;

        //test added
        try
        {
            RuntimeExample.LoadAvatar(url);
        }
        catch (Exception ex)
        {
            Debug.LogError("Exception during avatar loading: " + ex.Message);
        }
        //end test

    }
    private void OnLoadCompleted(object sender, CompletionEventArgs args)
    {
        print("OnLoadCompleted");

        if (avatar != null)
        {
            Destroy(avatar);
        }
        // print("pv-------" + pv.name);
        avatar = args.Avatar;
        // Re-parent and reset transforms
        avatar.transform.parent = transform;
        avatar.transform.localPosition = Vector3.zero; ;
        avatar.transform.localRotation = Quaternion.Euler(0, 0, 0);

        if (avatar.GetComponent<AvatarData>().AvatarMetadata.OutfitGender == OutfitGender.Masculine)
        {
            PlayerAnimator.avatar = MaleAvatar;
            isMale = true;
        }
        else
        {

            isMale = false;
            PlayerAnimator.avatar = femaleAvatar;
        }

        print("OnLoadCompletedDone222  == Avatar name is" + avatar.name);


    }





    private void OnLoadFailed(object sender, FailureEventArgs args)
    {
        print("OnLoadFailed" + args.Message);

        //OnLoadComplete?.Invoke();
    }

    public void MaleGender(string url)
    {
        LoadAvatarRuntime(url);
    }
    public void FemaleGender(string url)
    {
        LoadAvatarRuntime(url);
    }
    public void OtherGender(string url)
    {
        LoadAvatarRuntime(url);
    }

}
*/


