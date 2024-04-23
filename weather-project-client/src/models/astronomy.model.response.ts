import { Astronomy } from "./submodels/astronomy.model";
import { Location } from "./submodels/location.model";

export interface AstronomyModelResponse {
    location: Location;
    astronomy: Astronomy;
}