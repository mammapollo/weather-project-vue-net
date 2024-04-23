import { Current } from "./submodels/current.model";
import { Location } from "./submodels/location.model";

export interface RealTimeModelResponse {
    location: Location;
    current: Current;
}