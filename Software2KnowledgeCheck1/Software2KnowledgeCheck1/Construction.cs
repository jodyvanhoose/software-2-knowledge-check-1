namespace Software2KnowledgeCheck1
{
    internal class Construction : Building
    {

        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public void CreateApartment<T>(T building) where T : Building
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<T>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                Buildings.Add(building);
            }
        }
    }
}