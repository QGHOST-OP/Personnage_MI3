// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PeripheriqueEntree.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PeripheriqueEntree : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PeripheriqueEntree()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PeripheriqueEntree"",
    ""maps"": [
        {
            ""name"": ""JoueurAuSol"",
            ""id"": ""e61d8cd5-782d-485a-9aee-75481bcb3d95"",
            ""actions"": [
                {
                    ""name"": ""Deplacer"",
                    ""type"": ""Value"",
                    ""id"": ""1e32cbba-36c0-4f3f-bebb-eb6e281b7718"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sauter"",
                    ""type"": ""Button"",
                    ""id"": ""deb54a44-141c-4009-9c8c-fe3e5cd7892f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Regarder"",
                    ""type"": ""Value"",
                    ""id"": ""323450c0-a035-4bde-b328-4884b8eda2f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c2908734-b351-402f-99e7-1ead67d01015"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6403dd90-14be-43ab-a45a-e720c6fd069f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6a8897d3-43d2-41ad-96e5-912ded1471e2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d694297c-51db-4051-a5c7-9a90572f4b92"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ec2e06a8-2546-46e4-ba17-25f612f8482d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1f2aa218-5c42-4a45-b741-5d7949fdb918"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Fleches"",
                    ""id"": ""675b4bc6-931d-4b0b-9cfd-c542e8c8f7b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""62870c16-50bd-4299-951a-05aab42c98b5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a1282ecc-bd3a-4694-9adc-4d3cfe78a806"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec488b0b-af17-4e1f-becb-ed2f306e61f6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dbd14edc-5049-4fb8-82d0-1dec85e37a55"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9d4b0440-f41b-4292-a102-c33564e1fcad"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sauter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49818495-e74c-4f61-8110-7dce760463e3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sauter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fd624a2-4421-4b9e-a507-e0fc6bf957d7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Regarder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63e23907-9833-4b51-86be-044b8d683bfc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Regarder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // JoueurAuSol
        m_JoueurAuSol = asset.FindActionMap("JoueurAuSol", throwIfNotFound: true);
        m_JoueurAuSol_Deplacer = m_JoueurAuSol.FindAction("Deplacer", throwIfNotFound: true);
        m_JoueurAuSol_Sauter = m_JoueurAuSol.FindAction("Sauter", throwIfNotFound: true);
        m_JoueurAuSol_Regarder = m_JoueurAuSol.FindAction("Regarder", throwIfNotFound: true);
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

    // JoueurAuSol
    private readonly InputActionMap m_JoueurAuSol;
    private IJoueurAuSolActions m_JoueurAuSolActionsCallbackInterface;
    private readonly InputAction m_JoueurAuSol_Deplacer;
    private readonly InputAction m_JoueurAuSol_Sauter;
    private readonly InputAction m_JoueurAuSol_Regarder;
    public struct JoueurAuSolActions
    {
        private @PeripheriqueEntree m_Wrapper;
        public JoueurAuSolActions(@PeripheriqueEntree wrapper) { m_Wrapper = wrapper; }
        public InputAction @Deplacer => m_Wrapper.m_JoueurAuSol_Deplacer;
        public InputAction @Sauter => m_Wrapper.m_JoueurAuSol_Sauter;
        public InputAction @Regarder => m_Wrapper.m_JoueurAuSol_Regarder;
        public InputActionMap Get() { return m_Wrapper.m_JoueurAuSol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JoueurAuSolActions set) { return set.Get(); }
        public void SetCallbacks(IJoueurAuSolActions instance)
        {
            if (m_Wrapper.m_JoueurAuSolActionsCallbackInterface != null)
            {
                @Deplacer.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnDeplacer;
                @Deplacer.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnDeplacer;
                @Deplacer.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnDeplacer;
                @Sauter.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnSauter;
                @Sauter.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnSauter;
                @Sauter.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnSauter;
                @Regarder.started -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnRegarder;
                @Regarder.performed -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnRegarder;
                @Regarder.canceled -= m_Wrapper.m_JoueurAuSolActionsCallbackInterface.OnRegarder;
            }
            m_Wrapper.m_JoueurAuSolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Deplacer.started += instance.OnDeplacer;
                @Deplacer.performed += instance.OnDeplacer;
                @Deplacer.canceled += instance.OnDeplacer;
                @Sauter.started += instance.OnSauter;
                @Sauter.performed += instance.OnSauter;
                @Sauter.canceled += instance.OnSauter;
                @Regarder.started += instance.OnRegarder;
                @Regarder.performed += instance.OnRegarder;
                @Regarder.canceled += instance.OnRegarder;
            }
        }
    }
    public JoueurAuSolActions @JoueurAuSol => new JoueurAuSolActions(this);
    public interface IJoueurAuSolActions
    {
        void OnDeplacer(InputAction.CallbackContext context);
        void OnSauter(InputAction.CallbackContext context);
        void OnRegarder(InputAction.CallbackContext context);
    }
}
