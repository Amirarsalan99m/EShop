import { environment } from "../../environments/environment"

export const DomainName = environment.production ? 'https://localhost:7017/' : 'https://localhost:7017/'
