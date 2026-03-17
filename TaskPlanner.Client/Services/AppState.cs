using System;
using System.Collections.Generic;

namespace TaskPlanner.Client.Services
{
    public class AppState
    {
        public DateTime FechaSeleccionada { get; private set; } = DateTime.Today;

        public List<int> CategoriasOcultas { get; private set; } = new();

        public event Action? OnChange;

        public void CambiarFecha(DateTime fecha)
        {
            FechaSeleccionada = fecha;
            NotifyStateChanged();
        }

        public void ToggleCategoria(int categoriaId)
        {
            if (CategoriasOcultas.Contains(categoriaId)) CategoriasOcultas.Remove(categoriaId);
            else CategoriasOcultas.Add(categoriaId);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}