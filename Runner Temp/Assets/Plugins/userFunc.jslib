mergeInto(LibraryManager.library, {

    
    textChatOpen: function(userId,userName,userEmail,boothId,boothName,boothEmail)
    {
        openTextChat(userId,Pointer_stringify(userName),Pointer_stringify(userEmail),boothId,Pointer_stringify(boothName),Pointer_stringify(boothEmail));
    },
    managertextChatOpen: function(userId,boothName,boothEmail)
    {
        openManagerTextChat(userId,Pointer_stringify(boothName),Pointer_stringify(boothEmail));
    },
    StartPhoneCall: function(phoneNum)
    {
        phoneCallStart(Pointer_stringify(phoneNum));
    },
    DownloadImage: function(imageUrl)
    {
        DownloadImageStart(Pointer_stringify(imageUrl));
    },
    openRpm: function()
    {
        RpmStart();
    },
	OpenQnA: function()
    {
        openQNA();
    },
 JoinMeeting: function(username,channelId,usertype,emailId)
    {
        JoinVideoMeeting(Pointer_stringify(username),Pointer_stringify(channelId),Pointer_stringify(usertype),Pointer_stringify(emailId));
    },
 JoinPrivateMeeting: function(username,channelId,usertype)
    {
        JoinPrivateVideoMeeting(Pointer_stringify(username),Pointer_stringify(channelId),Pointer_stringify(usertype));
    },
DisconnectPrivateVoiceChat: function(emailId)
    {
       Disconnectvoicechat(Pointer_stringify(emailId));
    },
DownloadDoc: function(url,type,name)
    {
       DownloadDocAssets(Pointer_stringify(url),Pointer_stringify(type),Pointer_stringify(name));
    },
MuteUser: function(emailId,cmd)
    {
        MuteUnmuteUser(Pointer_stringify(emailId),Pointer_stringify(cmd));
    },
MuteAllUser: function(cmd)
    {
        MuteUnmuteAllUser(Pointer_stringify(cmd));
    }, 
    
 ShowGallery : function(user_id)
    {
	  console.log('ShowGalleryPanel->'+user_id);
        ShowGalleryPanel(Pointer_stringify(user_id));
    },

StartLiveDailyCoStream: function(username,usertype,youtubeurl,dailycourl,meetingtoken,activeurl)
    {
        StartLiveDailyCoStreamMeeting(Pointer_stringify(username),Pointer_stringify(usertype),Pointer_stringify(youtubeurl),Pointer_stringify(dailycourl),Pointer_stringify(meetingtoken),Pointer_stringify(activeurl));
    },
StopLiveDailyCoStream: function()
    {
        StopLiveDailyCoStreamMeeting();
    },
 IntelBoothFunction: function(boothid,type,name,email,comanyname,designation,door_id)
    {
         console.log('boothid->'+Pointer_stringify(boothid));
         console.log('name->'+Pointer_stringify(name));
         console.log('email->'+Pointer_stringify(email));
         console.log('comanyname->'+Pointer_stringify(comanyname));
         console.log('designation->'+Pointer_stringify(designation));
         console.log('door_id->'+Pointer_stringify(door_id));
         console.log('type->'+Pointer_stringify(type));
        IntelBoothFunctionality(Pointer_stringify(boothid),Pointer_stringify(type),Pointer_stringify(name),Pointer_stringify(email),Pointer_stringify(comanyname),Pointer_stringify(designation),Pointer_stringify(door_id));
        
    },
  ShowVideo: function(videoUrl)
    {
         console.log('videoUrl->'+Pointer_stringify(videoUrl));

        showvideo(Pointer_stringify(videoUrl));
        
    },

     StartLiveStreamOfConvo: function(cmd)
    {
	    console.log('StartLiveStreamOfConvo->'+cmd);
        StartLiveStreamOfConvocationIframe(Pointer_stringify(cmd));
    },
    
    StartLiveStreamOfPearl: function(cmd)
    {
	    console.log('StartLivePearlOfConvo->'+cmd);
        StartLiveStreamOfPearlIframe(Pointer_stringify(cmd));
    },

    RegisterSession: function(cmd)
    {
	    console.log('RegisterSession->'+cmd);
        RegisterLiveSession(Pointer_stringify(cmd));
    },
    GetSession: function()
    {
	    console.log('GetSession->');
        GetLiveSession(Pointer_stringify());
    },
    ApplyNow: function(cmd,url)
    {
	    console.log('ApplyNow->'+url);
        ApplyNowButton(Pointer_stringify(cmd),Pointer_stringify(url));
    },
    GetBrochuer: function(cmd,url)
    {
	    console.log('GetBrochuer->'+url);
        GetBrochuerButton(Pointer_stringify(cmd),Pointer_stringify(url));
    }, 
    OpenAdminPanel: function(cmd)
    {
	    console.log('OpenAdminPanel->');
        ShowAdminPanel(Pointer_stringify(cmd));
    }, 
    OpenUploadcontentPanel: function()
    {
	    console.log('OpenUploadcontentPanel->');
        OpenUploadcontent();
    },
    RecordingStatusUpdate: function(cmd)
    {
	    console.log('RecordingStatus->'+cmd);
        RecordingStatus(Pointer_stringify(cmd));
    }, 
       Openkeyboard: function(isActive) {
        console.log('StartConference->' + isActive);
        openkeyboard(Pointer_stringify(isActive));
    }, 
       GetDeviesType: function() {
        console.log('GetDeviesType->');
        getdeviestype();
    },
});