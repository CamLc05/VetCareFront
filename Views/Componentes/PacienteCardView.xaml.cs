using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Veterinaria.Models;

namespace Veterinaria.Views.Componentes;

public partial class PacienteCardView : ContentView
{
    public PacienteCardView()
    {
        InitializeComponent();
    }
    public static readonly BindableProperty PacienteProperty =
        BindableProperty.Create(nameof(Paciente), typeof(Paciente), typeof(PacienteCardView), propertyChanged: OnPacienteChanged);

    public Paciente Paciente
    {
        get => (Paciente)GetValue(PacienteProperty);
        set => SetValue(PacienteProperty, value);
    }

    private static void OnPacienteChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (PacienteCardView)bindable;
        control.BindingContext = control;
    }
}