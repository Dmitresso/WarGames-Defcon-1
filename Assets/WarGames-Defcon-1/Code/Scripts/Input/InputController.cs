using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public partial class @InputController : IInputActionCollection2, IDisposable {
        public InputActionAsset asset { get; }
        public @InputController() {
            asset = InputActionAsset.FromJson(@"{
        ""name"": ""WarGames Defcon 1"",
        ""maps"": [
            {
                ""name"": ""Player"",
                ""id"": ""8caea8bd-fdc6-4225-89a2-1b83e4ffb48a"",
                ""actions"": [
                    {
                        ""name"": ""Move"",
                        ""type"": ""Value"",
                        ""id"": ""77a19cc4-04f6-468c-9397-91369a1e2913"",
                        ""expectedControlType"": ""Vector2"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": true
                    },
                    {
                        ""name"": ""Rotate"",
                        ""type"": ""Value"",
                        ""id"": ""fe580224-3cda-43cf-83e4-5ce4f50b965e"",
                        ""expectedControlType"": ""Vector2"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": true
                    },
                    {
                        ""name"": ""Main Attack"",
                        ""type"": ""Button"",
                        ""id"": ""e230a516-2d1e-4dd6-841e-799112a9373f"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": ""Hold(duration=0.01)"",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Alternate Attack"",
                        ""type"": ""Button"",
                        ""id"": ""d7a7306d-0578-4a4d-8c6f-280af6821969"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": ""Hold(duration=0.01)"",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Change View"",
                        ""type"": ""Button"",
                        ""id"": ""05fe518d-d409-40f4-abb0-fcc911ef10cc"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Change Unit"",
                        ""type"": ""Button"",
                        ""id"": ""c976a1b9-4875-4c16-b9c7-1e5fbe60c9a9"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Command Center Menu"",
                        ""type"": ""Button"",
                        ""id"": ""10b3fbf0-0867-4cb2-ade4-2dac29ad8643"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Settings Menu"",
                        ""type"": ""Button"",
                        ""id"": ""30762783-dc82-4aab-9497-a3914613cb2e"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Command Menu"",
                        ""type"": ""Button"",
                        ""id"": ""ccc02c0e-ac4f-4e0f-9432-818057c5ba5e"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    }
                ],
                ""bindings"": [
                    {
                        ""name"": """",
                        ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                        ""path"": ""<Mouse>/leftButton"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""Main Attack"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""a50ce675-92b1-40a8-8fd5-cf107f4292a8"",
                        ""path"": ""<Mouse>/rightButton"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""Alternate Attack"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""4027f2bc-fab4-4824-b5ad-8a221ffe0c37"",
                        ""path"": ""<Keyboard>/e"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Change Unit"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""e196edbe-60a9-44f8-833c-b7c23df57864"",
                        ""path"": ""<Keyboard>/f"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Command Menu"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""c1e5c14d-067d-4751-87b1-79707d4adcec"",
                        ""path"": ""<Keyboard>/c"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Command Center Menu"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""66f6d1c0-08e5-46d7-91a4-a8459a653b7b"",
                        ""path"": ""<Keyboard>/v"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Settings Menu"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""AD"",
                        ""id"": ""617b9678-cb5c-44c1-80b0-7a8be62cb610"",
                        ""path"": ""2DVector"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Rotate"",
                        ""isComposite"": true,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""2be0c7bb-0053-4dbd-8c26-2320d1c6e551"",
                        ""path"": ""<Keyboard>/a"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Rotate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""d3b0effb-446e-4d95-bb41-6122be2f6dea"",
                        ""path"": ""<Keyboard>/leftArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Rotate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""6dac6c60-5cb2-4251-b025-3eb9df933f74"",
                        ""path"": ""<Keyboard>/d"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Rotate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""91261be4-d2dc-45be-8619-79bacdfae9fe"",
                        ""path"": ""<Keyboard>/rightArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Rotate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": """",
                        ""id"": ""bd6ea124-4c3e-4e6e-8f33-67eac46bdf43"",
                        ""path"": ""<Keyboard>/q"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Change View"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""WS"",
                        ""id"": ""3d64b0e9-c40c-4a8a-b69d-833bda0746fc"",
                        ""path"": ""2DVector"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Move"",
                        ""isComposite"": true,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""Up"",
                        ""id"": ""ab1b7590-2278-4cd8-96cb-b201d0c6a85d"",
                        ""path"": ""<Keyboard>/w"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""Move"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""up"",
                        ""id"": ""209abbec-c183-435a-8dbe-5070a5e5c6b0"",
                        ""path"": ""<Keyboard>/upArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""Move"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""3ffe78c6-aa6d-466c-a3e4-9fb0f06f98a9"",
                        ""path"": ""<Keyboard>/s"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Move"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""8a309b8b-2fa2-4456-9c3b-8362b0d222f1"",
                        ""path"": ""<Keyboard>/downArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Move"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    }
                ]
            },
            {
                ""name"": ""UI"",
                ""id"": ""c53bb742-2404-4410-9a68-43e37e7898ee"",
                ""actions"": [
                    {
                        ""name"": ""TrackedDeviceOrientation"",
                        ""type"": ""PassThrough"",
                        ""id"": ""fdd77720-a426-47a8-b959-b5999fea4d98"",
                        ""expectedControlType"": ""Quaternion"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""TrackedDevicePosition"",
                        ""type"": ""PassThrough"",
                        ""id"": ""bbf165fa-879e-41fb-9a28-0525ce651d66"",
                        ""expectedControlType"": ""Vector3"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""RightClick"",
                        ""type"": ""PassThrough"",
                        ""id"": ""88fadd72-c729-49e8-8e5f-fa2c220406ae"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""MiddleClick"",
                        ""type"": ""PassThrough"",
                        ""id"": ""b85505ec-fa09-473f-947f-cc15b902fce6"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""ScrollWheel"",
                        ""type"": ""PassThrough"",
                        ""id"": ""08ceecf9-abc9-4c62-9802-4fef7bbcd24c"",
                        ""expectedControlType"": ""Vector2"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Click"",
                        ""type"": ""PassThrough"",
                        ""id"": ""3feef39b-e1bc-469a-a227-0da235e7167e"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": true
                    },
                    {
                        ""name"": ""Point"",
                        ""type"": ""PassThrough"",
                        ""id"": ""44cd2cd8-69ac-4f22-83cc-f1727f5939c8"",
                        ""expectedControlType"": ""Vector2"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": true
                    },
                    {
                        ""name"": ""Cancel"",
                        ""type"": ""Button"",
                        ""id"": ""cee2f28b-bae9-4765-b100-860ea74efaed"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Submit"",
                        ""type"": ""Button"",
                        ""id"": ""f694d81b-f75d-42c2-9863-1f09c2427b71"",
                        ""expectedControlType"": ""Button"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    },
                    {
                        ""name"": ""Navigate"",
                        ""type"": ""PassThrough"",
                        ""id"": ""539f8335-73b6-4398-829c-d9073cbbf6bb"",
                        ""expectedControlType"": ""Vector2"",
                        ""processors"": """",
                        ""interactions"": """",
                        ""initialStateCheck"": false
                    }
                ],
                ""bindings"": [
                    {
                        ""name"": ""Gamepad"",
                        ""id"": ""46dc6149-7c89-492c-80bb-bf9cf90d67c7"",
                        ""path"": ""2DVector"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Navigate"",
                        ""isComposite"": true,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""up"",
                        ""id"": ""71c4f5d8-131c-4278-ac35-7ac428587598"",
                        ""path"": ""<Gamepad>/leftStick/up"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""up"",
                        ""id"": ""126eae8f-2f66-4818-9942-868fed1c3d96"",
                        ""path"": ""<Gamepad>/rightStick/up"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""26d8735a-bbb4-4da4-8c24-f446c2d89cc9"",
                        ""path"": ""<Gamepad>/leftStick/down"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""50ff1744-0fb0-48f9-8d4c-8cc4bcbb75de"",
                        ""path"": ""<Gamepad>/rightStick/down"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""737a1374-7a71-4611-afc4-af3f26a21dc0"",
                        ""path"": ""<Gamepad>/leftStick/left"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""287113d8-5052-4fbd-ba92-52d722802b75"",
                        ""path"": ""<Gamepad>/rightStick/left"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""518c62ae-ad8c-4c34-8995-9a025e82fc16"",
                        ""path"": ""<Gamepad>/leftStick/right"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""38b2ee46-65a1-4161-916e-9c81949f1eb3"",
                        ""path"": ""<Gamepad>/rightStick/right"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": """",
                        ""id"": ""8cefd078-288c-470b-b42e-d60af4173dc5"",
                        ""path"": ""<Gamepad>/dpad"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Gamepad"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""Joystick"",
                        ""id"": ""8e112788-1041-4ff8-9c7d-93df705a2d43"",
                        ""path"": ""2DVector"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Navigate"",
                        ""isComposite"": true,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""up"",
                        ""id"": ""d97ba6da-7c9c-4352-8111-37594ba64639"",
                        ""path"": ""<Joystick>/stick/up"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Joystick"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""d48ddbd6-4619-4122-a673-c7c0c1a832ea"",
                        ""path"": ""<Joystick>/stick/down"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Joystick"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""d5ae35fa-d008-4933-b122-f0df921ce4fc"",
                        ""path"": ""<Joystick>/stick/left"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Joystick"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""edbab165-91ad-4156-8bd1-3c00735c966c"",
                        ""path"": ""<Joystick>/stick/right"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Joystick"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""Keyboard"",
                        ""id"": ""8b1c4a2d-b9e1-4e90-b3b0-b4da41f70dda"",
                        ""path"": ""2DVector"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Navigate"",
                        ""isComposite"": true,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": ""up"",
                        ""id"": ""0d13ca82-7d2e-41cb-8e39-d4c12e477b36"",
                        ""path"": ""<Keyboard>/w"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""up"",
                        ""id"": ""8c2adc83-b524-4bad-b14c-3d471f840bc5"",
                        ""path"": ""<Keyboard>/upArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""9fd425a3-a13d-418d-832f-981c82ba4129"",
                        ""path"": ""<Keyboard>/s"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""down"",
                        ""id"": ""1cf7a926-9bad-409b-8061-a91ffecbbb9c"",
                        ""path"": ""<Keyboard>/downArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""71f6c3bd-34d3-4ed0-a86c-3e0fdad7d6f6"",
                        ""path"": ""<Keyboard>/a"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""left"",
                        ""id"": ""bd6e4575-9287-4aa0-a686-e73a630930d7"",
                        ""path"": ""<Keyboard>/leftArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""abe17ec0-70f2-4863-9b9b-08f73ea40695"",
                        ""path"": ""<Keyboard>/d"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": ""right"",
                        ""id"": ""215c31ef-b35e-4e9c-ba7e-555ca6333c4f"",
                        ""path"": ""<Keyboard>/rightArrow"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Navigate"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": true
                    },
                    {
                        ""name"": """",
                        ""id"": ""803033f1-f921-42ac-99f8-f780ac2ec7a9"",
                        ""path"": ""*/{Submit}"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Submit"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""34441456-840f-428e-8008-a916b5eddd6f"",
                        ""path"": ""*/{Cancel}"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": """",
                        ""action"": ""Cancel"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""2e2ed63a-6be4-4e6c-819e-51182499aa99"",
                        ""path"": ""<Mouse>/position"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Point"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""4f57160f-cba9-42e8-8a81-4dd2f2d920aa"",
                        ""path"": ""<Pen>/position"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Keyboard&Mouse"",
                        ""action"": ""Point"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""0b7d6507-bfbe-48f6-90e8-71b6b9574ad8"",
                        ""path"": ""<Touchscreen>/touch*/position"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Touch"",
                        ""action"": ""Point"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""18030bb6-2e0b-4ae6-ab61-e6b335ea7bd9"",
                        ""path"": ""<Mouse>/leftButton"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""Click"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""0cc93f92-4f0c-474b-bb7f-5da9b6c7af34"",
                        ""path"": ""<Pen>/tip"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""Click"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""dfcb75ef-f29d-4f43-bd55-46627a297f69"",
                        ""path"": ""<Touchscreen>/touch*/press"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""Touch"",
                        ""action"": ""Click"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""02b1449d-d97c-4092-a15d-250c05e35160"",
                        ""path"": ""<XRController>/trigger"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""XR"",
                        ""action"": ""Click"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""37aa47e5-88ea-4cf0-8590-e01cd25b4cef"",
                        ""path"": ""<Mouse>/scroll"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""ScrollWheel"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""6c71235a-5321-4244-95b8-5dd7dec07cf9"",
                        ""path"": ""<Mouse>/middleButton"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""MiddleClick"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""167ac636-8896-4656-abe2-6d2ccb49d337"",
                        ""path"": ""<Mouse>/rightButton"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": "";Keyboard&Mouse"",
                        ""action"": ""RightClick"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""b7c13d22-0f7d-4ca4-a1de-26d718833733"",
                        ""path"": ""<XRController>/devicePosition"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""XR"",
                        ""action"": ""TrackedDevicePosition"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    },
                    {
                        ""name"": """",
                        ""id"": ""752d9fc7-acac-4049-9d99-b2dcca6f7961"",
                        ""path"": ""<XRController>/deviceRotation"",
                        ""interactions"": """",
                        ""processors"": """",
                        ""groups"": ""XR"",
                        ""action"": ""TrackedDeviceOrientation"",
                        ""isComposite"": false,
                        ""isPartOfComposite"": false
                    }
                ]
            }
        ],
        ""controlSchemes"": [
            {
                ""name"": ""Keyboard&Mouse"",
                ""bindingGroup"": ""Keyboard&Mouse"",
                ""devices"": [
                    {
                        ""devicePath"": ""<Keyboard>"",
                        ""isOptional"": false,
                        ""isOR"": false
                    },
                    {
                        ""devicePath"": ""<Mouse>"",
                        ""isOptional"": false,
                        ""isOR"": false
                    }
                ]
            },
            {
                ""name"": ""Gamepad"",
                ""bindingGroup"": ""Gamepad"",
                ""devices"": [
                    {
                        ""devicePath"": ""<Gamepad>"",
                        ""isOptional"": false,
                        ""isOR"": false
                    }
                ]
            },
            {
                ""name"": ""Touch"",
                ""bindingGroup"": ""Touch"",
                ""devices"": [
                    {
                        ""devicePath"": ""<Touchscreen>"",
                        ""isOptional"": false,
                        ""isOR"": false
                    }
                ]
            },
            {
                ""name"": ""Joystick"",
                ""bindingGroup"": ""Joystick"",
                ""devices"": [
                    {
                        ""devicePath"": ""<Joystick>"",
                        ""isOptional"": false,
                        ""isOR"": false
                    }
                ]
            },
            {
                ""name"": ""XR"",
                ""bindingGroup"": ""XR"",
                ""devices"": [
                    {
                        ""devicePath"": ""<XRController>"",
                        ""isOptional"": false,
                        ""isOR"": false
                    }
                ]
            }
        ]
    }");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
            m_Player_MainAttack = m_Player.FindAction("Main Attack", throwIfNotFound: true);
            m_Player_AlternateAttack = m_Player.FindAction("Alternate Attack", throwIfNotFound: true);
            m_Player_ChangeView = m_Player.FindAction("Change View", throwIfNotFound: true);
            m_Player_ChangeUnit = m_Player.FindAction("Change Unit", throwIfNotFound: true);
            m_Player_CommandCenterMenu = m_Player.FindAction("Command Center Menu", throwIfNotFound: true);
            m_Player_SettingsMenu = m_Player.FindAction("Settings Menu", throwIfNotFound: true);
            m_Player_CommandMenu = m_Player.FindAction("Command Menu", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
            m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
            m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
            m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
            m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
            m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
            m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
            m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
            m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
            m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_Rotate;
        private readonly InputAction m_Player_MainAttack;
        private readonly InputAction m_Player_AlternateAttack;
        private readonly InputAction m_Player_ChangeView;
        private readonly InputAction m_Player_ChangeUnit;
        private readonly InputAction m_Player_CommandCenterMenu;
        private readonly InputAction m_Player_SettingsMenu;
        private readonly InputAction m_Player_CommandMenu;
        public struct PlayerActions
        {
            private @InputController m_Wrapper;
            public PlayerActions(@InputController wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
            public InputAction @MainAttack => m_Wrapper.m_Player_MainAttack;
            public InputAction @AlternateAttack => m_Wrapper.m_Player_AlternateAttack;
            public InputAction @ChangeView => m_Wrapper.m_Player_ChangeView;
            public InputAction @ChangeUnit => m_Wrapper.m_Player_ChangeUnit;
            public InputAction @CommandCenterMenu => m_Wrapper.m_Player_CommandCenterMenu;
            public InputAction @SettingsMenu => m_Wrapper.m_Player_SettingsMenu;
            public InputAction @CommandMenu => m_Wrapper.m_Player_CommandMenu;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @MainAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMainAttack;
                    @MainAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMainAttack;
                    @MainAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMainAttack;
                    @AlternateAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlternateAttack;
                    @AlternateAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlternateAttack;
                    @AlternateAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlternateAttack;
                    @ChangeView.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeView;
                    @ChangeView.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeView;
                    @ChangeView.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeView;
                    @ChangeUnit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeUnit;
                    @ChangeUnit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeUnit;
                    @ChangeUnit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeUnit;
                    @CommandCenterMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandCenterMenu;
                    @CommandCenterMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandCenterMenu;
                    @CommandCenterMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandCenterMenu;
                    @SettingsMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSettingsMenu;
                    @SettingsMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSettingsMenu;
                    @SettingsMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSettingsMenu;
                    @CommandMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandMenu;
                    @CommandMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandMenu;
                    @CommandMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandMenu;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Rotate.started += instance.OnRotate;
                    @Rotate.performed += instance.OnRotate;
                    @Rotate.canceled += instance.OnRotate;
                    @MainAttack.started += instance.OnMainAttack;
                    @MainAttack.performed += instance.OnMainAttack;
                    @MainAttack.canceled += instance.OnMainAttack;
                    @AlternateAttack.started += instance.OnAlternateAttack;
                    @AlternateAttack.performed += instance.OnAlternateAttack;
                    @AlternateAttack.canceled += instance.OnAlternateAttack;
                    @ChangeView.started += instance.OnChangeView;
                    @ChangeView.performed += instance.OnChangeView;
                    @ChangeView.canceled += instance.OnChangeView;
                    @ChangeUnit.started += instance.OnChangeUnit;
                    @ChangeUnit.performed += instance.OnChangeUnit;
                    @ChangeUnit.canceled += instance.OnChangeUnit;
                    @CommandCenterMenu.started += instance.OnCommandCenterMenu;
                    @CommandCenterMenu.performed += instance.OnCommandCenterMenu;
                    @CommandCenterMenu.canceled += instance.OnCommandCenterMenu;
                    @SettingsMenu.started += instance.OnSettingsMenu;
                    @SettingsMenu.performed += instance.OnSettingsMenu;
                    @SettingsMenu.canceled += instance.OnSettingsMenu;
                    @CommandMenu.started += instance.OnCommandMenu;
                    @CommandMenu.performed += instance.OnCommandMenu;
                    @CommandMenu.canceled += instance.OnCommandMenu;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_TrackedDeviceOrientation;
        private readonly InputAction m_UI_TrackedDevicePosition;
        private readonly InputAction m_UI_RightClick;
        private readonly InputAction m_UI_MiddleClick;
        private readonly InputAction m_UI_ScrollWheel;
        private readonly InputAction m_UI_Click;
        private readonly InputAction m_UI_Point;
        private readonly InputAction m_UI_Cancel;
        private readonly InputAction m_UI_Submit;
        private readonly InputAction m_UI_Navigate;
        public struct UIActions
        {
            private @InputController m_Wrapper;
            public UIActions(@InputController wrapper) { m_Wrapper = wrapper; }
            public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
            public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
            public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
            public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
            public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
            public InputAction @Click => m_Wrapper.m_UI_Click;
            public InputAction @Point => m_Wrapper.m_UI_Point;
            public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
            public InputAction @Submit => m_Wrapper.m_UI_Submit;
            public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                    @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                    @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                    @MiddleClick.started += instance.OnMiddleClick;
                    @MiddleClick.performed += instance.OnMiddleClick;
                    @MiddleClick.canceled += instance.OnMiddleClick;
                    @ScrollWheel.started += instance.OnScrollWheel;
                    @ScrollWheel.performed += instance.OnScrollWheel;
                    @ScrollWheel.canceled += instance.OnScrollWheel;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                }
            }
        }
        public UIActions @UI => new UIActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        private int m_JoystickSchemeIndex = -1;
        public InputControlScheme JoystickScheme
        {
            get
            {
                if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
                return asset.controlSchemes[m_JoystickSchemeIndex];
            }
        }
        private int m_XRSchemeIndex = -1;
        public InputControlScheme XRScheme
        {
            get
            {
                if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
                return asset.controlSchemes[m_XRSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
            void OnMainAttack(InputAction.CallbackContext context);
            void OnAlternateAttack(InputAction.CallbackContext context);
            void OnChangeView(InputAction.CallbackContext context);
            void OnChangeUnit(InputAction.CallbackContext context);
            void OnCommandCenterMenu(InputAction.CallbackContext context);
            void OnSettingsMenu(InputAction.CallbackContext context);
            void OnCommandMenu(InputAction.CallbackContext context);
        }
        public interface IUIActions
        {
            void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
            void OnTrackedDevicePosition(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
            void OnMiddleClick(InputAction.CallbackContext context);
            void OnScrollWheel(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnNavigate(InputAction.CallbackContext context);
        }
    }
}