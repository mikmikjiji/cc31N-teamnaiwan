@@ -8,17 +8,37 @@
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Engine.ViewModels;
namespace CC31N_SNOOKERS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();
          DataContext = _gameSession;
        }
        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
    }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }

    } 
}
 42 changes: 42 additions & 0 deletions42  
Engine/Engine.csproj
@@ -0,0 +1,42 @@
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0-windows</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <UseWpf>true</UseWpf>


  </PropertyGroup>

  <ItemGroup>
    <Compile Remove="Images\Locations\Home.jpg\**" />
    <EmbeddedResource Remove="Images\Locations\Home.jpg\**" />
    <None Remove="Images\Locations\Home.jpg\**" />
  </ItemGroup>

  <ItemGroup>
    <None Remove="Images\Locations\AlmaMarketSquare.jpg" />
    <None Remove="Images\Locations\BenuFarmField.jpg" />
    <None Remove="Images\Locations\BenuFarmHouse.jpg" />
    <None Remove="Images\Locations\DawnWoodForest.png" />
    <None Remove="Images\Locations\EldoriaTownSquare.png" />
    <None Remove="Images\Locations\GrassyLand.png" />
    <None Remove="Images\Locations\Home.jpg" />
    <None Remove="Images\Locations\LynxCabin.png" />
    <None Remove="Images\Locations\TownGate.png" />
  </ItemGroup>

  <ItemGroup>
    <Resource Include="Images\Locations\AlmaMarketSquare.jpg" />
    <Resource Include="Images\Locations\BenuFarmField.jpg" />
    <Resource Include="Images\Locations\BenuFarmHouse.jpg" />
    <Resource Include="Images\Locations\DawnWoodForest.png" />
    <Resource Include="Images\Locations\EldoriaTownSquare.png" />
    <Resource Include="Images\Locations\GrassyLand.png" />
    <Resource Include="Images\Locations\Home.jpg" />
    <Resource Include="Images\Locations\LynxCabin.png" />
    <Resource Include="Images\Locations\TownGate.png" />
  </ItemGroup>

</Project>
 26 changes: 26 additions & 0 deletions26  
Engine/Factories/WorldFactory.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
   internal class WorldFactory
    {
        public World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Player's Home", "This is the place where you currently live", "/Engine;component/Images/Locations/Home.jpg");
            newWorld.AddLocation(-1, -1, "Benu Farm House", "This is your neighbour's house  named Benu", "/Engine;component/Images/Locations/BenuFarmHouse.jpg");
            newWorld.AddLocation(-2, -1, "Benu's Farm Field", "This place is Benu's Corn field.Its a grassy field with wild animals", "/Engine;component/Images/Locations/BenuFarmField.jpg");
            newWorld.AddLocation(0, 1, "Lynx Cabin", "This is shop of Lynx where you can trade,buy items and potions. of Lynx ", "/Engine;component/Images/Locations/LynxCabin.png");
            newWorld.AddLocation(0, 2, "Grassy Land", "This place is filled with tall grasses where wild giant animals live.", "/Engine;component/Images/Locations/GrassyLand.png");
            newWorld.AddLocation(1, 0, "Town Gate", "A huge gate in the town protecting from the Wild Bear and unknown creatures", "/Engine;component/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Dawn Wood Forest", "A place filled with tall trees and wild giant animals", "/Engine;component/Images/Locations/DawnWoodForest.png");
            newWorld.AddLocation(-1, 0, "Alma Market Shop", "The market shop of Alma.He sells weapons and other items", "/Engine;component/Images/Locations/AlmaMarketSquare.jpg");
            newWorld.AddLocation(0, 0, "Eldoria Town Square", "A beautiful town of Eldoria", "/Engine;component/Images/Locations/EldoriaTownSquare.png");
            return newWorld;
        }
    }
}